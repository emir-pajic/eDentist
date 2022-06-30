using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using eDentist.WebAPI.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Service
{
    public class UserService : CRUDService<MUsers, UsersSearchRequest, Users, UsersUpsertRequest, UsersUpsertRequest>, IUserService
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public UserService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async override Task<List<MUsers>> Get(UsersSearchRequest search)
        {
            var query = _context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role).AsQueryable().OrderBy(c => c.FirstName);

            //if (!string.IsNullOrWhiteSpace(search?.Username))
            //{
            //    query = query.Where(x => x.Username.ToLower().StartsWith(search.Username.ToLower())).OrderBy(c => c.FirstName);
            //}
            var list = await query.ToListAsync();
            return _mapper.Map<List<MUsers>>(list);
        }

        public override async Task<MUsers> GetById(int ID)
        {
            var entity = await _context.Set<Users>()
                .Where(i => i.UserId == ID)
                .Include(i => i.UserRoles)
                .SingleOrDefaultAsync();

            return _mapper.Map<MUsers>(entity);
        }
        public override async Task<MUsers> Insert(UsersUpsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            var entity = _mapper.Map<Users>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var roleID in request.Roles)
            {
                var role = new UserRoles()
                {
                    UserId = entity.UserId,
                    RoleId = roleID,


                };

                await _context.UserRoles.AddAsync(role);
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<MUsers>(entity);
        }
        public override async Task<MUsers> Update(int ID, UsersUpsertRequest request)
        {
            var entity = _context.Users.Find(ID);

            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwords do not match!");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            foreach (var RoleID in request.Roles)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleId == RoleID && i.UserId == ID)
                    .SingleOrDefaultAsync();

                if (userRole == null)
                {
                    var newRole = new UserRoles()
                    {
                        UserId = ID,
                        RoleId = RoleID
                    };
                    await _context.Set<UserRoles>().AddAsync(newRole);
                }
            }

            foreach (var RoleID in request.RolesToDelete)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleId == RoleID && i.UserId == ID)
                    .SingleOrDefaultAsync();

                if (userRole != null)
                {
                    _context.Set<UserRoles>().Remove(userRole);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MUsers>(entity);
        }
        public async Task<MUsers> Authenticate(UserAuthenticationRequest request)
        {
            var user = await _context.Users
                .Include(i => i.UserRoles)
                .ThenInclude(j => j.Role)
                .FirstOrDefaultAsync(i => i.Username == request.Username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, request.Password);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<MUsers>(user);
                }
            }
            return null;
        }
        public async Task<MUsers> Register(UsersUpsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }
            request.Roles = new List<int> { 2, 3 };
            var entity = _mapper.Map<Users>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MUsers>(entity);
        }
        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Users.
                Include(i => i.UserRoles).
                Include(j => j.Appointments).
                FirstOrDefaultAsync(i => i.UserId == ID);

            if (entity.UserRoles.Count != 0)
                _context.UserRoles.RemoveRange(entity.UserRoles);




            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }


        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
