using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Service
{
    public class AppointmentsService : CRUDService<MAppointments, AppointmentsSearchRequest, Appointments, AppointmentsUpsertRequest, AppointmentsUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public AppointmentsService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }


    }
}
