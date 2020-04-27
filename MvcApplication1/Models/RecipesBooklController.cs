using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class RecipesBookController : Controller
    {
        //
        // GET: /RecipesBook.cshtml/

        public ActionResult Index()
        {
            return View();
        }

    }
}
