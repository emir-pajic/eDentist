
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : CRUDController<MManufacturers, ManufacturersSearchRequest, ManufacturersUpsertRequest, ManufacturersUpsertRequest>
    {

        public ManufacturersController(ICRUDService<MManufacturers, ManufacturersSearchRequest, ManufacturersUpsertRequest, ManufacturersUpsertRequest> service) : base(service)
        {

        }


    }
}

