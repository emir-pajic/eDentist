namespace eDentist.Model.Request
{
    public class ExaminationUpsertRequest
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
