namespace eDentist.Model.Request
{
    public class TreatmentsMaterialsUpsertRequest
    {
        public int TreatmentMaterialId { get; set; }
        public int? TreatmentId { get; set; }
        public int? MaterialId { get; set; }
    }
}
