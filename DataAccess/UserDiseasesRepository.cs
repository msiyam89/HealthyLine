using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class UserDiseasesRepository
    {

        public static UserDiseases GetUserDiseases(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.UserDiseases.Where(x => x.Id == id).FirstOrDefault();
            }

        }

       

        public static bool CreateUserDiseases(UserDiseases userdiseases)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.UserDiseases.Add(userdiseases);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateUserDiseases(UserDiseases updateuserdiseases)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.UserDiseases.First<UserDiseases>();
                update.ProfileId = updateuserdiseases.ProfileId;
                update.DiseasesId = updateuserdiseases.DiseasesId;
               context.SaveChanges();

                return true;

            }
        }

       

        public static bool DeleteUserDiseasese(UserDiseases deleteuserdiseases)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.UserDiseases.First<UserDiseases>();
                context.UserDiseases.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }

}
