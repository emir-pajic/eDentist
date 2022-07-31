using System;

namespace eDentist.Model
{
    public partial class Examination
    {
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public string Status { get; set; }
        public string Treatment { get; set; }
    }
}
