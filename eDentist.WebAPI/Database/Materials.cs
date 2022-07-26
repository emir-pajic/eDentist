using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public int? ManufacturerId { get; set; }

        public Manufacturers Manufacturer { get; set; }
        public virtual ICollection<TreatmentsMaterials> TreatmentsMaterials { get; set; }
    }
}
