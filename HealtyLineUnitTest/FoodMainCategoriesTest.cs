using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class FoodMainCategoriesTest
    {
        [TestMethod]
        public void GetFoodMainCategories()
        {
            var FoodMainCategories = DataAccess.FoodMainCategoriesRepositry.GetFoodMainCategories(1);
        }


        [TestMethod]
        public void CreateFoodMainCategories()
        {
            var foodmaincategories = new FoodMainCategories()
            {
               CategoryNameArabic="الاكل",
               CategoryNameEnglish="foood",
            };

            var create = DataAccess.FoodMainCategoriesRepositry.UpdateFoodMainCategories(foodmaincategories);
        }


        [TestMethod]
        public void UpdateFoodMainCategories()
        {
            var foodmaincategoriesupdate = new FoodMainCategories()
            {
                CategoryNameArabic = "الاكل",
                CategoryNameEnglish = "foood",
            };
            var create = DataAccess.FoodMainCategoriesRepositry.UpdateFoodMainCategories(foodmaincategoriesupdate);

        }
        [TestMethod]
        public void DeleteFoodMainCategories()
        {
            var foodmaincategoriesdelete = DataAccess.FoodMainCategoriesRepositry.GetFoodMainCategories(1);
            var create = DataAccess.FoodMainCategoriesRepositry.DeleteFoodMainCategories(foodmaincategoriesdelete);

        }



    }
}

