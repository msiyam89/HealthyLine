﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CalorieGuideController : BaseController
    {
        //
        // GET: /CalorieGuide/

        public ActionResult CalorieGuide()
        {
            ViewBag.Title = "Calorie Guide";
            return View();
        }

    }
}
