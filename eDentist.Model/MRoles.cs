using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MRoles
    {
        public MRoles()
        {
            UserRoles = new HashSet<MUserRoles>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MUserRoles> UserRoles { get; set; }
    }
}
