using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MTreatmentsMaterials
    {
      
        public int TreatmentMaterialId { get; set; }
        public int? TreatmentId { get; set; }
        public int? MaterialId { get; set; }

       
    }
}
