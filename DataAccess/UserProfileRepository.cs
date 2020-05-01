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


        public static bool CreateUserProfile(UserProfile userProfile)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.UserProfile.Add(userProfile);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateUserProfile(UserProfile updateuserProfile)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.UserProfile.First<UserProfile>();
                update.FullNameArabic = updateuserProfile.FullNameArabic;
                update.MobileNumber = updateuserProfile.MobileNumber;
                update.BirthDate = updateuserProfile.BirthDate;
                update.Gender = updateuserProfile.Gender;
                update.FullNameEnglish = updateuserProfile.FullNameEnglish;

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
