using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DiseasesRepositry
    {

        public static Diseases GetDiseases(int id)
        {

            using (var context = new HealthyLineeEntities())
            {
                return context.Diseases.Where(x => x.Id == id).FirstOrDefault();
            }

        }


        public static bool CreateDiseases(Diseases diseases)
        {
            using (var context = new HealthyLineeEntities())
            {


                context.Diseases.Add(diseases);
                context.SaveChanges();

                return true;

            }
        }


        public static bool UpdateDiseases(Diseases updatediseases)
        {
            using (var context = new HealthyLineeEntities())
            {

                var update = context.Diseases.First<Diseases>();
                update.NameArabic = updatediseases.NameArabic;
                update.NameEnglish = updatediseases.NameEnglish;

                context.SaveChanges();
                return true;

            }
        }
        public static bool DeleteDiseases(Diseases deletediseases)
        {
            using (var context = new HealthyLineeEntities())
            {
                var delete = context.Diseases.First<Diseases>();
                context.Diseases.Remove(delete);

                context.SaveChanges();
                return true;
            }




        }
    }


}
