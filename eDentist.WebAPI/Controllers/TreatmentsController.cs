
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentsController : CRUDController<MTreatments, TreatmentSearchRequest, TreatmentsUpsertRequest, TreatmentsUpsertRequest>
    {

        public TreatmentsController(ICRUDService<MTreatments, TreatmentSearchRequest, TreatmentsUpsertRequest, TreatmentsUpsertRequest> service) : base(service)
        {

        }


    }
}

