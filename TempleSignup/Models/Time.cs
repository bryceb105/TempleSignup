using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignup.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string DateTime { get; set; }

        [Required]
        public bool Available { get; set; } = true;

    }
}
