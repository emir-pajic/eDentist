
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : CRUDController<MMaterials, MaterialsSearchRequest, MaterialsUpsertRequest, MaterialsUpsertRequest>
    {

        public MaterialsController(ICRUDService<MMaterials, MaterialsSearchRequest, MaterialsUpsertRequest, MaterialsUpsertRequest> service) : base(service)
        {

        }


    }
}

