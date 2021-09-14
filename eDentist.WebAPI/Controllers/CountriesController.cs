
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : CRUDController<MCountries, CountriesSearchRequest, CountriesUpsertRequest, CountriesUpsertRequest>
    {

        public CountriesController(ICRUDService<MCountries, CountriesSearchRequest, CountriesUpsertRequest, CountriesUpsertRequest> service) : base(service)
        {

        }


    }
}

