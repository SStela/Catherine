

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Catherine.Model.Cities;
using Catherine.Model.Citizenships;

namespace Catherine.Model.Countries
{
    public class Country : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string President { get; set; }

        [MaxLength(100)]
        public string PrimeMinister { get; set; }

        public ICollection<Citizenship> Citizenships { get; set; }
        public ICollection<City> Cities { get; set; }

    }
}