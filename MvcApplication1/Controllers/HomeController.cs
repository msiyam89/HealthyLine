
using MvcApplication1.Helper;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MvcApplication1.LocalResource;

namespace MvcApplication1.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult ChangeCurrentCulture(int id)
        {
            //  
            // Change the current culture for this user.  
            //  
            CultureHelper.CurrentCulture = id;
            //  
            // Cache the new current culture into the user HTTP session.   
            //  
            Session["CurrentCulture"] = id;
            //  
            // Redirect to the same page from where the request was made!   
            //  
            return Redirect(Request.UrlReferrer.ToString());
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Home page";
            return View();

        }

        private ActionResult View(Func<ActionResult> idealWeight, Func<string, ContentResult> content)
        {
            throw new NotImplementedException();
        }

   

      
        public ActionResult RecipesBook()
        {
            ViewBag.Title = "Recipes Book";
            return View();

        }
        public ActionResult CalorieGuide()
        {
            ViewBag.Title = "Calorie Guide";
            return View();
        }
        //public ActionResult IdealWeight()
        //{
        //    ViewBag.Title = "IdealWeight";

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult IdealWeight(IdealWeightModel model)
        //{
        //    decimal ideal = model.weight / (model.height * model.height);
        //    ViewBag.Title = "IdealWeight";

        //    return View();
        //}

        public ActionResult Exercise()
        {
            ViewBag.Title = "Exercise";

            return View();
        }
        public ActionResult Page4()
        {
            ViewBag.Title = "Contact";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Models.ContactUsModel model)
        {
            if (ModelState.IsValid)
            {
                //Message message = new Message
                //   {
                //       Name = model.Name,

                //       Number = model.Number,
                //       Emaill = model.Emaill,
                //       Subject = model.Subject,
                //       MessageText = model.Message

                //   };

            }
            return View();
        }
       
    }


}