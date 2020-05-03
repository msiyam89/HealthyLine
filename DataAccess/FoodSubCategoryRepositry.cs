using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class FoodSubCategoryRepositry
    {

        public static FoodSubCategory GetFoodSubCategory(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.FoodSubCategory.Where(x => x.Id == id).FirstOrDefault();
            }

        }


        public static bool CreateUserProfile(FoodSubCategory foodsubcategory)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.FoodSubCategory.Add(foodsubcategory);
                context.SaveChanges();

                return true;

            }
        }

        public static object CreateFoodSubCategory(FoodSubCategory foodsubcategory)
        {
            throw new NotImplementedException();
        }

        public static bool UpdateFoodSubCategory(FoodSubCategory updatefoodsubcategory)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.FoodSubCategory.First<FoodSubCategory>();
                update.MainCategoryId = updatefoodsubcategory.MainCategoryId;
                update.SubCategoryNameArabic = updatefoodsubcategory.SubCategoryNameArabic;
                update.SubCategoryNameEnglish = updatefoodsubcategory.SubCategoryNameEnglish;
                update.Calories = updatefoodsubcategory.Calories;

                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteFoodSubCategory(FoodSubCategory deletefoodsubcategory)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.FoodSubCategory.First<FoodSubCategory>();
                context.FoodSubCategory.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}


