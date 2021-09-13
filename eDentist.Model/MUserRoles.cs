// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MUserRoles
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual MRoles Role { get; set; }
        public virtual MUsers User { get; set; }
    }
}
