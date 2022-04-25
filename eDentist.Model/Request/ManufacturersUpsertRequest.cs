using System;
using System.Collections.Generic;
using System.Text;

namespace eDentist.Model.Request
{
    public class ManufacturersUpsertRequest
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public int FoundationYear { get; set; }
        public int? CountryId { get; set; }
    }
}
