using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class RecipesIngredientsRepositry
    {

        public static RecipesIngredients GetRecipesIngredients(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.RecipesIngredients.Where(x => x.Id == id).FirstOrDefault();
            }

        }


        public static bool CreateRecipesIngredients(RecipesIngredients recipesingredients)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.RecipesIngredients.Add(recipesingredients);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateRecipesIngredients(RecipesIngredients updaterecipesingredients)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.RecipesIngredients.First<RecipesIngredients>();
                update.Ingredient = updaterecipesingredients.Ingredient;
                update.RecipeId = updaterecipesingredients.RecipeId;
               

                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteRecipesIngredientse(RecipesIngredients deleterecipesingredients)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.RecipesIngredients.First<RecipesIngredients>();
                context.RecipesIngredients.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}


