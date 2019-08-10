using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Catherine.Model.Citizenships;

namespace Catherine.Model.Citizens
{
    public class Citizen : BaseModel
    {
        [Required]
        [StringLength(11)]
        public string VatNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Paycheck { get; set; }

        public ICollection<Citizenship> Citizenships { get; set; }
    }
}