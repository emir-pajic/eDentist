using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MTreatments
    {
        public MTreatments()
        {
            TreatmentsMaterials = new HashSet<MTreatmentsMaterials>();
        }

        public int TreatmentId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MTreatmentsMaterials> TreatmentsMaterials { get; set; }
    }
}
