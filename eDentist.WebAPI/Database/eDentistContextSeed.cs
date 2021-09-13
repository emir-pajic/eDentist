using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Database
{
    public partial class eDentistContext
    {
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

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {


            List<string> Salt = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Salt.Add(GenerateSalt());
            }

            modelBuilder.Entity<Countries>().HasData(

                new Countries
                {
                    CountryId = 1,
                    CountryName = "Bosnia and Herzegovina"
                });

            modelBuilder.Entity<Cities>().HasData(

                new Cities
                {
                    CityId = 1,
                    CityName = "Konjic",
                    CountryId = 1
                });

            modelBuilder.Entity<Users>().HasData
            (
                new Users
                {
                    UserId = 1,
                    FirstName = "Emir",
                    LastName = "Pajić",
                    Username = "Pajson",
                    CityId = 1,
                    Email = "emir.pajic@edu.fit.ba",
                    DateOfBirth = DateTime.Now,
                    Telephone = "061-918-661",                   
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "pajson1"),
                },
                new Users
                {
                    UserId = 2,
                    FirstName = "Emir",
                    LastName = "Pajić",
                    Username = "Pajson2",
                    CityId = 1,
                    Email = "emir.pajic2@edu.fit.ba",
                    DateOfBirth = DateTime.Now,
                    Telephone = "061-918-661",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "pajson2"),
                }                
            );
            modelBuilder.Entity<Roles>().HasData
            (
                new Roles { RoleId = 1, Name = "Admin" },
                new Roles { RoleId = 2, Name = "Patient" },
                new Roles { RoleId = 3, Name = "Staff" }
            );
           
            modelBuilder.Entity<UserRoles>().HasData(
                new UserRoles { UserRoleId = 1, UserId = 1, RoleId = 1 },
                new UserRoles { UserRoleId = 2, UserId = 2, RoleId = 2 }               
                );
            



        }
    }
}
