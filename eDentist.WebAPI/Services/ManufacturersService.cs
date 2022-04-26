using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Service
{
    public class ManufacturersService : CRUDService<MManufacturers, ManufacturersSearchRequest, Manufacturers, ManufacturersUpsertRequest, ManufacturersUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public ManufacturersService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Manufacturers.
                Include(i => i.Materials).
                FirstOrDefaultAsync(i => i.ManufacturerId == ID);

            //if (entity.Users.Count != 0)
            //{

            //}

            _context.Manufacturers.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}
