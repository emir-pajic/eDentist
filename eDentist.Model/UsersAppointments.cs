﻿using System;

namespace eDentist.Model
{
    public partial class UsersAppointments
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Status { get; set; }

    }
}
