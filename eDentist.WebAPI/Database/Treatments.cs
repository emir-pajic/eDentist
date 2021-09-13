using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Treatments
    {
        public Treatments()
        {
            TreatmentsMaterials = new HashSet<TreatmentsMaterials>();
        }

        public int TreatmentId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TreatmentsMaterials> TreatmentsMaterials { get; set; }
    }
}
