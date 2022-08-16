using System;

namespace eDentist.Model.Request
{
    public class AppointmentsUpsertRequest
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public int? DayId { get; set; }
        public bool Status { get; set; }
        public string AppointmentStatus { get; set; }

    }
}
