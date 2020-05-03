using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class RecipesStepsTest
    {
        [TestMethod]
        public void GetRecipesStepsTest()
        {
            var recipessteps = DataAccess.RecipesStepsRepositry.GetRecipesSteps(1);
        }


        [TestMethod]
        public void CreateRecipesSteps()
        {
            var recipessteps = new RecipesSteps()
            {
                RecipeId = 5,
                StepDetails = "",
            };

            var create = DataAccess.RecipesStepsRepositry.Createrecipessteps(recipessteps);
        }


        [TestMethod]
        public void UpdateRecipesSteps()
        {
            
            var updaterecipessteps = new RecipesSteps()
            {
                RecipeId = 2,
                StepDetails = "",

            };
            var create = DataAccess.RecipesStepsRepositry.UpdaterecipesSteps(updaterecipessteps);

        }
        [TestMethod]
        public void DeleteRecipesSteps()
        {
            var recipesstepsdelete = DataAccess.RecipesStepsRepositry.GetRecipesSteps(1);
            var create = DataAccess.RecipesStepsRepositry.DeleteRecipesSteps(recipesstepsdelete);

        }



    }
}

