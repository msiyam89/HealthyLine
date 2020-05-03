using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class SignupModel
    {
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Fullname { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
       
        public string Email { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 6)]
        public string Username { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }


        // this is a shame.
    }
}