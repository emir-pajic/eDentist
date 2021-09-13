using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Materials
    {
        public Materials()
        {
            TreatmentsMaterials = new HashSet<TreatmentsMaterials>();
        }

        public int MaterialId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TreatmentsMaterials> TreatmentsMaterials { get; set; }
    }
}
