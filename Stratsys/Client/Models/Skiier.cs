using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Skiier
    {
        [Required(ErrorMessage = "Must be a numeric value")]
        public int? Length { get; set; }
        [Required(ErrorMessage = "Must be a numeric value")]
        public int? Age { get; set; }
        public Style Style { get; set; }
        public string SkiLength { get; set; }
    }
}
