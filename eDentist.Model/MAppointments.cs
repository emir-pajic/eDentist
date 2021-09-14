using Newtonsoft.Json;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MAppointments
    {
        
        
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public int? DayId { get; set; }
        public bool Status { get; set; }

        public virtual MDays Day { get; set; }
        
    }
}
