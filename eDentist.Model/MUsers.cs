using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MUsers
    {
        public MUsers()
        {
            Appointments = new HashSet<MAppointments>();
            Examinations = new HashSet<MExaminations>();
            UserRoles = new HashSet<MUserRoles>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int? CityId { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual MCities City { get; set; }
        public virtual ICollection<MAppointments> Appointments { get; set; }
        public virtual ICollection<MExaminations> Examinations { get; set; }
        public virtual ICollection<MUserRoles> UserRoles { get; set; }
    }
}
