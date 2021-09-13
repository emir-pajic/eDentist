using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Days
    {
        public Days()
        {
            Appointments = new HashSet<Appointments>();
        }
        [Key]
        public int DayId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
