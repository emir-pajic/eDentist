
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentsMaterialsController : CRUDController<MTreatmentsMaterials, TreatmentsMaterialsSearchRequest, TreatmentsMaterialsUpsertRequest, TreatmentsMaterialsUpsertRequest>
    {

        public TreatmentsMaterialsController(ICRUDService<MTreatmentsMaterials, TreatmentsMaterialsSearchRequest, TreatmentsMaterialsUpsertRequest, TreatmentsMaterialsUpsertRequest> service) : base(service)
        {

        }


    }
}

