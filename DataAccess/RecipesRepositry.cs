using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class RecipesRepositry
    {

        public static Recipes GetRecipes(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.Recipes.Where(x => x.Id == id).FirstOrDefault();
            }

        }

        

        public static bool CreateRecipes(Recipes recipes)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.Recipes.Add(recipes);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateRecipes(Recipes updaterecipes)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.Recipes.First<Recipes>();
                update.RecipesNameArabic = updaterecipes.RecipesNameArabic;
                update.RecipesNameEnglish = updaterecipes.RecipesNameEnglish;
              

                context.SaveChanges();
                return true;

            }
        }

        

        public static bool DeleteRecipes(Recipes deleterecipes)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.Recipes.First<Recipes>();
                context.Recipes.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}







