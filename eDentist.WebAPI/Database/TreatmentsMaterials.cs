using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class TreatmentsMaterials
    {
        public TreatmentsMaterials()
        {
            Examinations = new HashSet<Examinations>();
        }
        [Key]
        public int TreatmentMaterialId { get; set; }
        public int? TreatmentId { get; set; }
        public int? MaterialId { get; set; }

        public virtual Materials Material { get; set; }
        public virtual Treatments Treatment { get; set; }
        public virtual ICollection<Examinations> Examinations { get; set; }
    }
}
