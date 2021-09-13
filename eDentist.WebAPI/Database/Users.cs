using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Users
    {
        public Users()
        {
            Appointments = new HashSet<Appointments>();
            Examinations = new HashSet<Examinations>();
            UserRoles = new HashSet<UserRoles>();
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

        public virtual Cities City { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Examinations> Examinations { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
