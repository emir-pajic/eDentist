using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Appointments
    {
        public Appointments()
        {
            Examinations = new HashSet<Examinations>();
        }

        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public int? DayId { get; set; }
        public bool Status { get; set; }

        public virtual Days Day { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Examinations> Examinations { get; set; }
    }
}
