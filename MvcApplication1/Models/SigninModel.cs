using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class SigninModel : Controller
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        //[Required]
        //[System.ComponentModel.DataAnnotations.Compare("Password")]
        //public string Confirm { get; set; }
    }
}
