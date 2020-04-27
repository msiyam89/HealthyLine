using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class Contact : Controller
    {
        //
        // GET: /Contact/
        public string Name { get; set; }
        public string Number{ get; set; }
        public string Emaill { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
