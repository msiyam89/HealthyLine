using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class RecipesTest
    {
        [TestMethod]
        public void GetRecipes()
        {
            var recipes = DataAccess.RecipesRepositry.GetRecipes(1);
        }


        [TestMethod]
        public void CreateRecipes()
        {
            var recipes = new Recipes()
            {
               RecipesNameArabic="",
               RecipesNameEnglish="",
            };

            var create = DataAccess.RecipesRepositry.CreateRecipes(recipes);
        }


        [TestMethod]
        public void UpdateRecipes()
        {
            var recipesupdate = new Recipes()
            {
               RecipesNameArabic="",
               RecipesNameEnglish="",

            };
            var create = DataAccess.RecipesRepositry.UpdateRecipes(recipesupdate);

        }
        [TestMethod]
        public void DeleteRecipes()
        {
            var recipesdelete = DataAccess.RecipesRepositry.GetRecipes(1);
            var create = DataAccess.RecipesRepositry.DeleteRecipes(recipesdelete);

        }



    }
}
