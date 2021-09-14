
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationsController : CRUDController<MExaminations, ExaminationsSearchRequest, ExaminationUpsertRequest, ExaminationUpsertRequest>
    {

        public ExaminationsController(ICRUDService<MExaminations, ExaminationsSearchRequest, ExaminationUpsertRequest, ExaminationUpsertRequest> service) : base(service)
        {

        }


    }
}

