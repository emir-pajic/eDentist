﻿// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.Model
{
    public partial class MExaminations
    {
        public int ExaminationId { get; set; }
        public string AdditionalInfo { get; set; }
        public int? AppointmentId { get; set; }
        public int? UserId { get; set; }
        public int? TreatmentId { get; set; }

        public string Status { get; set; }
        public int? TreatmentsMaterialsId { get; set; }
        public string PaymentTokenId { get; set; }

    }
}
