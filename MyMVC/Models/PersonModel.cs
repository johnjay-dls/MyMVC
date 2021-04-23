using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class PersonModel
    {
       
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [StringLength(200)]
        public string Lastname { get; set; }
        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        [Required]

        public string Contactnumber { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]

        public string Confirmpassword { get; set; }

    }
}
