
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication1.Controllers
{
    public class UserProfile : Controller
    {
        //
        // GET: /UserProfile/

        public ActionResult Index(UserProfile userProfile)

        {
            //UserProfile GetUserProfile(int id)
            {
                // using (var context = new HealthyLineeEntities())

                HealthyLineeEntities db = new HealthyLineeEntities();

                // var userProfile = context.UserProfile();
                //User user = new User();
                //user.Password=userProfile.



                //HealthyLineeEntities db = new HealthyLineeEntities();
                //UserProfile user = new UserProfile();

                return View();
            }


        }
    }
}
