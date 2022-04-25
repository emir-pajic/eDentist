namespace eDentist.Model.Request
{
    public class CitiesUpsertRequest
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? CountryId { get; set; }
    }
}
