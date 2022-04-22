using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Service
{
    public class CountriesService : CRUDService<MCountries, CountriesSearchRequest, Countries, CountriesUpsertRequest, CountriesUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public CountriesService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       


    }
}
