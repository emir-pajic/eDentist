using System;
using System.Collections.Generic;
using System.Text;

namespace eDentist.Model
{
    public partial class UsersAppointments
    {
        public DateTime Date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Status { get; set; }

    }
}
