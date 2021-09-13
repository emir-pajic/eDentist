using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Examinations
    {
        public int ExaminationId { get; set; }
        public string AdditionalInfo { get; set; }
        public int? AppointmentId { get; set; }
        public int? UserId { get; set; }
        public string Status { get; set; }
        public int? TreatmentsMaterialsId { get; set; }
        public string PaymentTokenId { get; set; }

        public virtual Appointments Appointment { get; set; }
        public virtual TreatmentsMaterials TreatmentsMaterials { get; set; }
        public virtual Users User { get; set; }
    }
}
