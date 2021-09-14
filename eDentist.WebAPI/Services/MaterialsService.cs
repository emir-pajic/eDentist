using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

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


    }
}
