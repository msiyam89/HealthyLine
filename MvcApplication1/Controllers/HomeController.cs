using DataAccess;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Home page";
            return View();

        }


        public ActionResult DiteAndNutritaionService()
        {
            ViewBag.Title = "Diet programs";
            return View();
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
        public ActionResult IdealWeight()
        {
            ViewBag.Title = "IdealWeight";

            return View();
        }

        [HttpPost]
        public ActionResult IdealWeight(IdealWeightModel model)
        {
            decimal ideal = model.weight / (model.height * model.height);
            ViewBag.Title = "IdealWeight";

            return View();
        }

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
        public ActionResult Contact(Models.Contact model)
        {
            if (ModelState.IsValid)
            {
                Message message = new Message
                   {
                       Name = model.Name,

                       Number = model.Number,
                       Emaill = model.Emaill,
                       Subject = model.Subject,
                       MessageText = model.Message

                   };

            }
            return View();
        }
       
    }


}