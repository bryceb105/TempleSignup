using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        public int id { get; set; }

        //[Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }

        //[Required]
        public string DateTime { get; set; }

        //[Required(ErrorMessage = "Please enter a valid GroupSize (between 1 & 15) : ")]
        [Range(1, 15)]
        public int GroupSize { get; set; }


        //[Required(ErrorMessage = "Please enter a valid email address: ")]
        [EmailAddress]
        public string Email { get; set; }


        [Phone]
        public string Phone { get; set; }


    }
}
