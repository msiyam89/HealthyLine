using MvcApplication1.LocalResource;
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
        [Display(Name = "UserName", ResourceType = typeof(Resource))]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string Password { get; set; }
       
    }
}
