using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MCountries
    {
        public MCountries()
        {
            Cities = new HashSet<MCities>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<MCities> Cities { get; set; }
    }
}
