using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Service
{
    public class CitiesService : CRUDService<MCities, CitiesSearchRequest, Cities, CitiesUpsertRequest, CitiesUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public CitiesService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Cities.
                Include(i => i.Users).                
                FirstOrDefaultAsync(i => i.CityId == ID);

            //if (entity.Users.Count != 0)
            //{
                
            //}

            _context.Cities.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}
