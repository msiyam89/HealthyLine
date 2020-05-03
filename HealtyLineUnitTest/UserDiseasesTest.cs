using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class UserDiseasesTest

    {
        public UserDiseases userdiseasesupdate;

        [TestMethod]
        public void GetUserDiseases()
        {
            var UserDiseases = DataAccess.UserDiseasesRepository.GetUserDiseases(1);
        }


        [TestMethod]
        public void CreateUserDiseases()
        {
            var UserDiseases = new UserDiseases()
            {
                DiseasesId = 2,
                ProfileId = 3,

            };

            var create = DataAccess.UserDiseasesRepository.CreateUserDiseases(UserDiseases);
        }


        [TestMethod]
        public void UpdateUserDiseases()
        {
            var userUserDiseases = new UserDiseases()
            {
                DiseasesId = 2,
                ProfileId = 3,

            };
            var create = DataAccess.UserDiseasesRepository.UpdateUserDiseases(userdiseasesupdate);

        }
        [TestMethod]
        public void DeleteUserProfile()
        {
            var userdiseasesdelete = DataAccess.UserDiseasesRepository.GetUserDiseases(1);
            var create = DataAccess.UserDiseasesRepository.DeleteUserDiseasese(userdiseasesdelete);

        }



    }
}
