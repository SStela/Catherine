using System;
using System.ComponentModel.DataAnnotations;
using Catherine.Model.Citizens;
using Catherine.Model.Countries;

namespace Catherine.Model.Citizenships
{
    public class Citizenship
    {
        public long CitizenId { get; set; }
        public Citizen Citizen { get; set; }

        public long CountryId { get; set; }

        public Country Country { get; set; }

        [DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Date)]
        public DateTime? ValidTo { get; set; }
    }
}