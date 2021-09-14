using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

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


    }
}
