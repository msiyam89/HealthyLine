using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class RecipesStepsRepositry
    {

        public static RecipesSteps GetRecipesSteps(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.RecipesSteps.Where(x => x.Id == id).FirstOrDefault();
            }

        }


        public static bool Createrecipessteps(RecipesSteps recipessteps)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.RecipesSteps.Add(recipessteps);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdaterecipesSteps(RecipesSteps updaterecipessteps)
        { 
            using (var context = new HealthyLineeEntities())
            {

                var update = context.RecipesSteps.First<RecipesSteps>();
                update.RecipeId = updaterecipessteps.RecipeId;
                update.StepDetails = updaterecipessteps.StepDetails;
               

                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteRecipesSteps(RecipesSteps deleterecipessteps)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.RecipesSteps.First<RecipesSteps>();
                context.RecipesSteps.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}

