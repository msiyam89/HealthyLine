
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class FoodMainCategoriesRepositry
    {
        private static object updateCategoryNameArabic;

        public static FoodMainCategories GetFoodMainCategories(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.FoodMainCategories.Where(x => x.Id == id).FirstOrDefault();
            }

        }


        public static bool CreateFoodMainCategories(FoodMainCategories foodmaincategories)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.FoodMainCategories.Add(foodmaincategories);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateFoodMainCategories(FoodMainCategories updatefoodmaincategories)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.FoodMainCategories.First<FoodMainCategories>();
                update.CategoryNameArabic = updatefoodmaincategories.CategoryNameArabic;
                update.CategoryNameEnglish = updatefoodmaincategories.CategoryNameEnglish;



                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteFoodMainCategories(FoodMainCategories deletefoodmaincategories)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.FoodMainCategories.First<FoodMainCategories>();
                context.FoodMainCategories.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}

















