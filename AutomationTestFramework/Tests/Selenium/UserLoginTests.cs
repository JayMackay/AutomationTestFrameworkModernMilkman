//using AutomationTestFramework.Library;
//using NUnit.Framework;
//using NUnit.Allure.Core;
//using NUnit.Allure.Attributes;
//using Allure.Commons;

//namespace automationtestframework.tests.selenium
//{
//    [TestFixture]
//    [AllureNUnit]
//    [AllureSuite("UserLoginTest")]
//    [AllureDisplayIgnored]
//    public class UserLoginTest
//    {
//        //Instantiate the page objects, include all functionality for the web pages
//        public MainProjectConstructor _constructor;

//        [Test(Description = "User login")]
//        [AllureTag("CI")]
//        [AllureSeverity(SeverityLevel.critical)]
//        [AllureIssue("8911")]
//        [AllureTms("532")]
//        [AllureOwner("Jared")]
//        [AllureSubSuite("Add")]
//        public void UserLoginFullPath()
//        {
//            //Instantiate Firefox driver & main page model
//            _constructor = new MainProjectConstructor("firefox");

//            //Stepping functions
//            _constructor = new MainProjectConstructor("firefox");
//            _constructor.WebsiteHomePage.VisitHomePage();
//            _constructor.WebsiteHomePage.SignIn();
//            Assert.That(_constructor.WebsiteLoginPage.LoginHeaderCheck(),
//                Is.EqualTo("Login"));

//            _constructor.WebsiteLoginPage.UserLogin("07987654320", "adminPassword");

//            Assert.That(_constructor.WebsiteUserHomePage.UserMilkDeliveryCheck(),
//                Is.EqualTo("Milk"));
//        }
//    }
//}