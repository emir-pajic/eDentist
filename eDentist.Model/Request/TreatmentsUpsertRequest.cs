namespace eDentist.Model.Request
{
    public class TreatmentsUpsertRequest
    {
        public int TreatmentId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
