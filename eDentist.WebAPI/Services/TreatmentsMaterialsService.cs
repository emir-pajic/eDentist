using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Service
{
    public class TreatmentsMaterialsService : CRUDService<MTreatmentsMaterials, TreatmentsMaterialsSearchRequest, TreatmentsMaterials, TreatmentsMaterialsUpsertRequest, TreatmentsMaterialsUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public TreatmentsMaterialsService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }


    }
}
