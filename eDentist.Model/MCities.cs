using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MCities
    {
        public MCities()
        {
            Users = new HashSet<MUsers>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }

        public virtual MCountries Country { get; set; }
        public virtual ICollection<MUsers> Users { get; set; }
    }
}
