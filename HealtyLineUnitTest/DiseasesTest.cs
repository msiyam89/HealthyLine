using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class DiseasesTest
    {
        [TestMethod]
        public void GetDiseases()
        {
            var Diseases = DataAccess.DiseasesRepositry.GetDiseases(1);
        }


        [TestMethod]
        public void CreateDiseases()
        {
            var diseases = new Diseases()
            {
                NameArabic="ضحى",
                NameEnglish="Doha",
            };

            var create = DataAccess.DiseasesRepositry.CreateDiseases(diseases);
        }


        [TestMethod]
        public void UpdateDiseases()
        {
            var diseasesupdate = new Diseases()
            {
                NameArabic = "منار",
                NameEnglish = "manar",

            };
            var create = DataAccess.DiseasesRepositry.UpdateDiseases(diseasesupdate);

        }
        [TestMethod]
        public void Deletediseases()
        {
            var diseasesdelete = DataAccess.DiseasesRepositry.GetDiseases(1);
            var create = DataAccess.DiseasesRepositry.DeleteDiseases(diseasesdelete);

        }



    }
}













