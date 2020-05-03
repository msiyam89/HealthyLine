using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class FoodSubCategoryTest
    {
        [TestMethod]
        public void GetFoodSubCategory()
        {
            var userProfile = DataAccess.FoodSubCategoryRepositry.GetFoodSubCategory(1);
        }


        [TestMethod]
        public void CreateFoodSubCategory()
        {
            var foodsubcategory = new FoodSubCategory()
            {
                SubCategoryNameArabic= "الاكل",
                SubCategoryNameEnglish="food",
                MainCategoryId=3,
                Calories=100,
            };

            var create = DataAccess.FoodSubCategoryRepositry.CreateFoodSubCategory(foodsubcategory);
        }


        [TestMethod]
        public void UpdateFoodSubCategory()
        {
            var foodsubcategoryupdate = new FoodSubCategory()
            {
                SubCategoryNameArabic= "الاكل",
                SubCategoryNameEnglish= "food",
                MainCategoryId=4,
                Calories=110,
            };
            var create =DataAccess.FoodSubCategoryRepositry.UpdateFoodSubCategory(foodsubcategoryupdate);

        }
        [TestMethod]
        public void Deletefoodsubcategory()
        {
            var foodsubcategorydelete = DataAccess.FoodSubCategoryRepositry.GetFoodSubCategory(1);
            var create = DataAccess.FoodSubCategoryRepositry.DeleteFoodSubCategory(foodsubcategorydelete);

        }



    }
}
