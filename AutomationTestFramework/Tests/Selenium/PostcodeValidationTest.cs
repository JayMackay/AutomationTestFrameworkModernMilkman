using AutomationTestFramework.Library;
using NUnit.Framework;

namespace AutomationTestFramework.Tests.Selenium
{
    [TestFixture]
    public class PostcodeValidationTest
    {
        //Instantiate the page objects, include all functionality for the web pages
        public MainProjectConstructor _constructor;

        [Test]
        public void PostcodeValidationTestFullPath()
        {
            //Instantiate Chrome driver & main page model
            _constructor = new MainProjectConstructor("firefox");

            //STEPPING FUNCTIONS
            _constructor.WebsiteHomePage.VisitHomePage();
            Assert.That(_constructor.WebsiteHomePage.HomePageWelcomeMessage,
                Is.EqualTo("Fresh milk and groceries delivered plastic free"));
            _constructor.WebsiteHomePage.EnterAvailableValidPostcode("LS20 8JN");
            _constructor.WebsiteHomePage.SearchPostcode();

            Assert.That(_constructor.WebsiteRegistrationPage.RegistrationPageWelcomeMessage,
                Is.EqualTo("Good news! We deliver in your area."));
        }
    }
}
