﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class Countries
    {
        public Countries()
        {
            Cities = new HashSet<Cities>();
            Manufacturers = new HashSet<Manufacturers>();
        }
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<Manufacturers> Manufacturers { get; set; }

    }
}
