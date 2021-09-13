using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MDays
    {
        public MDays()
        {
            Appointments = new HashSet<MAppointments>();
        }

        public int DayId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MAppointments> Appointments { get; set; }
    }
}
