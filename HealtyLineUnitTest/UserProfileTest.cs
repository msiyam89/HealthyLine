using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class UserProfileTest
    {
        [TestMethod]
        public void GetUserProfile()
        {
            var userProfile = DataAccess.UserProfileRepository .GetUserProfile(1);
        }


        [TestMethod]
        public void CreateUserProfile()
        {
            var userProfile = new UserProfile()
            {
                UserName = "TestUser2",
                BirthDate = DateTime.Now,
                CreatedBy = "Manar",
                CreatedDate = DateTime.Now,
                CurrentWeight = 50.0,
                Email = "mmmmm@mmm.com",
                FullNameArabic = "FullNameArabic",
                FullNameEnglish = "FullNameEnglish",
                Gender = true,
                Height = 170,
                IdealWeight = 10.0,
                IsActive = true,
                MobileNumber = "009665488421",
                Password = "123456",
                TargetWeight = 50.0,
            };

            var create = DataAccess.UserProfileRepository.CreateUserProfile(userProfile);
        }


        [TestMethod]
        public void UpdateUserProfile()
        {
            var userprofileupdate = new UserProfile()
            {
                FullNameArabic = "مناره",
                FullNameEnglish = "manar",

            };
            var create = DataAccess.UserProfileRepository.UpdateUserProfile(userprofileupdate);
        
        }
        [TestMethod]
        public void DeleteUserProfile()
        {
            var userprofiledelete = DataAccess.UserProfileRepository.GetUserProfile(1);
            var create = DataAccess.UserProfileRepository.DeleteUserProfile(userprofiledelete);

        }



    }
}
