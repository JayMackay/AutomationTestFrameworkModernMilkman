using NUnit.Framework;
using AutomatedTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class PostcodeValidationSteps
    {
        private MainProjectConstructor _constructor;

        [Given(@"I am on the website main home page")]
        public void WebsiteMainHomePage()
        {
            _constructor = new MainProjectConstructor("Chrome");
            _constructor.WebsiteHomePage.VisitHomePage();
        }

        [When(@"I input a valid postcode")]
        public void InputValidPostcode()
        {
            _constructor.WebsiteHomePage.EnterAvailableValidPostcode("LS20 8JN");
        }

        [Then(@"I should be redirected to the registration page")]
        public void RedirectToRegistrationPage()
        {
            Assert.That(_constructor.RegistrationPage.

        }
    }
}
