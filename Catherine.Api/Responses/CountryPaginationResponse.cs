using System.Collections.Generic;
using Catherine.Model.Cities;
using Catherine.Model.Citizenships;

namespace Catherine.Api.Responses
{
    public class CountryResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string President { get; set; }
        public string PrimeMinister { get; set; }
        public ICollection<City> Cities { get; set; }
        public int CityCount { get; set; }
    }
}