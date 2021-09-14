
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : CRUDController<MAppointments, AppointmentsSearchRequest, AppointmentsUpsertRequest, AppointmentsUpsertRequest>
    {

        public AppointmentsController(ICRUDService<MAppointments, AppointmentsSearchRequest, AppointmentsUpsertRequest, AppointmentsUpsertRequest> service) : base(service)
        {

        }


    }
}

