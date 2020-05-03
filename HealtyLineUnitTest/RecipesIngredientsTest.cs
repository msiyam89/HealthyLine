using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class RecipesIngredientsTest
    {
        [TestMethod]
        public void GetRecipesIngredients()
        {
            var recipesingredients =DataAccess.RecipesIngredientsRepositry.GetRecipesIngredients(1);
        }


        [TestMethod]
        public void CreateRecipesIngredients()
        {
            var recipesingredients = new RecipesIngredients()
            {
               RecipeId=4,
               Ingredient="",
            };

            var create = DataAccess.RecipesIngredientsRepositry.CreateRecipesIngredients(recipesingredients);
        }


        [TestMethod]
        public void UpdateRecipesIngredients()
        {
            var recipesingredientsupdate = new RecipesIngredients()
            {
                RecipeId=4,
                Ingredient="",

            };
            var create = DataAccess.RecipesIngredientsRepositry.UpdateRecipesIngredients(recipesingredientsupdate);

        }
        [TestMethod]
        public void DeleteRecipesIngredients()
        {
            var recipesingredientsdelete = DataAccess.RecipesIngredientsRepositry.GetRecipesIngredients(1);
            var create = DataAccess.RecipesIngredientsRepositry.DeleteRecipesIngredientse(recipesingredientsdelete);

        }



    }
}

