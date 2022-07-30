using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Service
{
    public class MaterialsService : CRUDService<MMaterials, MaterialsSearchRequest, Materials, MaterialsUpsertRequest, MaterialsUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public MaterialsService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Materials.
                Include(i => i.TreatmentsMaterials).
                FirstOrDefaultAsync(i => i.MaterialId == ID);

            //if (entity.Users.Count != 0)
            //{

            //}

            _context.Materials.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
