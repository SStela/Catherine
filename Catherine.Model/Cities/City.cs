using System.ComponentModel.DataAnnotations;
using Catherine.Model.Countries;

namespace Catherine.Model.Cities
{
    public class City : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool IsCapital { get; set; } = false;

        public long CountryId { get; set; }
        public Country Country { get; set; }
    }
}