using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignup.Models
{
    public class TempleModel
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int TimeId { get; set; }
        public Time Time { get; set; }

        [Required]
        [Range(1, 15)]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }


    }
}
