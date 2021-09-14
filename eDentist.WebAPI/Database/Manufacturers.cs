using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Database
{
    public partial class Manufacturers
    {
        public Manufacturers()
        {
            Materials = new HashSet<Materials>();
        }
        [Key]
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public int FoundationYear { get; set; }
        public int CountryId { get; set; }
        public Countries Country { get; set; }

        public virtual ICollection<Materials> Materials { get; set; }



    }
}
