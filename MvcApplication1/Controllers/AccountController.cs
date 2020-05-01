using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using System.Web.Security;
using System.Data.SqlClient;

namespace MvcApplication1.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
             public ActionResult Signin(Models.SigninModel model)
             {

                 if (ModelState.IsValid)
                 {
                  

                     DataAccess.UserProfile user = null;
                     using (HealthyLineeEntities ctx = new HealthyLineeEntities())
                     {
                         user = ctx.UserProfile.SingleOrDefault(x => x.UserName == model.Username && x.Password == model.Password);
                     }

                     if (user != null)
                     {
                          FormsAuthentication.SetAuthCookie(user.UserName, true);
                         
                         return Redirect("~");
                    }
                     else
                     {
                         return View();
                     }
                 }
                 else
                 {
                     return View();
                 }

             }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Models.SignupModel model)
        {
            ViewBag.Error = "";
            if (ModelState.IsValid)
            {
                    DataAccess.UserProfile user = new DataAccess.UserProfile
                    {
                        FullNameArabic = model.Fullname,
                        Gender = model.Gender,
                        Email = model.Email,
                        Password = model.Password
                    };

                    try
                    {
                        using (HealthyLineeEntities ctx = new HealthyLineeEntities())
                        {
                            if (ctx.UserProfile.Where(x => x.Email == model.Email).Count() > 0)
                            {
                                ViewBag.Erroe = "User already exists.";
                            }
                            else
                            {
                                user = ctx.UserProfile.Add(user);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Error = ex.Message;
                    }

            }




            return View();
        }
        public ActionResult Signout() {
            FormsAuthentication.SignOut();
            return Redirect("~");
         
        }
        
            
        public ActionResult Atkinsdiet()
        {
            return View();
        }
        public ActionResult Zonediet()
        {
            return View();
        }
        public ActionResult Ketogenicdiet()
        {
            return View();
        }
        public ActionResult Vegetariandiet()
        {
            return View();
        }
        
        public ActionResult Vegandiet()
        {
            return View();
        }
        public ActionResult WeightWatchersdiet()
        {
            return View();
        }
        public ActionResult SouthBeachdiet()
        {
            return View();
        }
        public ActionResult Rawfooddiet()
        {
            return View();
        }
        public ActionResult Mediterraneandiet()
        {
            return View();
        }
        public ActionResult Potato()
        {
            return View();
        }
        public ActionResult Boiled()
        {
            return View();
        }
        public ActionResult Grilledfish()
        {
            return View();
        }
        public ActionResult Beef()
        {
            return View();
        }
        public ActionResult Grilledchicken()
        {
            return View();
        }
        public ActionResult Chinese()
        {
            return View();
        }
        public ActionResult Bulgurtomato()
        {
            return View();
        }
        public ActionResult Grilledchickenlemon()
        {
            return View();
        }
        public ActionResult BroccoliLight()
        {
            return View();
        }
        public ActionResult crisppancake()
        {
            return View();
        }
        public ActionResult Asparagus()
        {
            return View();
        }
        public ActionResult Chickenhot()
        {
            return View();
        }
        public ActionResult Mushroomchicken()
        {
            return View();
        }
        public ActionResult Indiansamosa()
        {
            return View();
        }
        public ActionResult Marinatedchicken()
        {
            return View();
        }
      



    }

}
