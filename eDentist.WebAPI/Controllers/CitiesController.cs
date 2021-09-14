
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : CRUDController<MCities, CitiesSearchRequest, CitiesUpsertRequest, CitiesUpsertRequest>
    {

        public CitiesController(ICRUDService<MCities, CitiesSearchRequest, CitiesUpsertRequest, CitiesUpsertRequest> service) : base(service)
        {

        }


    }
}

