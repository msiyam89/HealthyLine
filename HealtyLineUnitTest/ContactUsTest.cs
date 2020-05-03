using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealtyLineUnitTest
{
    [TestClass]
    public class ContactUsTest
    {
        [TestMethod]
        public void GetContactUs()
        {
            var contactus = DataAccess.ContactUsRepositry. GetContactUs(1);
        }


        [TestMethod]
        public void CreateContactUs()
        {
            var contactus = new ContactUs()
            {
                FullNameEnglish = "khadooj",
                FullNameArabic = "خدووج",
                Messaage = "السلام",
                UserName = "sarah",
                UserEmail = "manar@hotmail.com",
            };

            var create = DataAccess.ContactUsRepositry.CreateContactUs(contactus);
        }


        [TestMethod]
        public void UpdateContactUs()
        {
            var contactusupdate = new ContactUs()
            {
               Id = 1 ,
               
               UserEmail="manar@hotmail.com",
            };
            var create = DataAccess.ContactUsRepositry.UpdateContactUs(contactusupdate);

        }
        [TestMethod]
        public void DeleteContactUs()
        {
            var deletecontactus = DataAccess.ContactUsRepositry.GetContactUs(1);
            var create = DataAccess.ContactUsRepositry.DeleteContactUs(deletecontactus);

        }



    }
}














