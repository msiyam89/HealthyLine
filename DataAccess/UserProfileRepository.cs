using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class UserProfileRepository
    {

        public static UserProfile GetUserProfile(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.UserProfile.Where(x => x.Id == id).FirstOrDefault();
            }

        }
        public static List<UserProfile> GetAll()
        {
            using (var context = new HealthyLineeEntities())
            {
                return context.UserProfile.ToList();
            }

        }

        public static bool CreateUserProfile(UserProfile userProfile)
        {
            using (var context = new HealthyLineeEntities())
            {

                context.UserProfile.Add(userProfile);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateUserProfile(UserProfile updateUserProfile)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.UserProfile.First<UserProfile>();
                update = updateUserProfile;

                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteUserProfile(UserProfile deleteuserProfile)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.UserProfile.First<UserProfile>();
                    context.UserProfile.Remove(delete);

                    context.SaveChanges();
                return true;
                }




            }
        }
           

        }
