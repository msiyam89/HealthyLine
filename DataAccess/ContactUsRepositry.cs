using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ContactUsRepositry
    {

        public static ContactUs GetContactUs(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.ContactUs.Where(x => x.Id == id).FirstOrDefault();
            }

        }


        public static bool CreateContactUs(ContactUs contactus)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.ContactUs.Add(contactus);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateContactUs(ContactUs updatecontactus)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.ContactUs.First<ContactUs>();
                update = updatecontactus;

                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteContactUs(ContactUs deletecontactus)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.ContactUs.First<ContactUs>();
                context.ContactUs.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}
