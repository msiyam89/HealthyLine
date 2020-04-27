using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public static class UserBZ
    {
        public static void AddUser(User user){

                using (DAContext ctx = new DAContext())
                {
                    // check if user exists.
                    if (ctx.Users.Where(x => x.Email == user.Email).Count() > 0)
                    {
                        throw new Exception("User Exists");
                    }
                    else
                    {
                        ctx.Users.Add(user);
                        ctx.SaveChanges();
                    }
                }
            
        }

        public static User FindUserByCredentials(string p1, string p2)
        {
            User user = null;
            using (DAContext ctx = new DAContext())
            {
                user = ctx.Users.SingleOrDefault(x=>x.Email == p1&&x.Password == p2);
            }
            return user;
        }
    }
}
