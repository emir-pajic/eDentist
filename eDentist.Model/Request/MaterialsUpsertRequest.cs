namespace eDentist.Model.Request
{
    public class MaterialsUpsertRequest
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }

    }
}
