using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eDentist.WebAPI.Service
{
    public class TreatmentsService : CRUDService<MTreatments, TreatmentSearchRequest, Treatments, TreatmentsUpsertRequest, TreatmentsUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public TreatmentsService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Treatments.
                Include(i => i.TreatmentsMaterials).

                FirstOrDefaultAsync(i => i.TreatmentId == ID);

            //if (entity.Users.Count != 0)
            //{

            //}

            _context.Treatments.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
