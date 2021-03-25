using NUnit.Framework;
using AutomationTestFramework.Library;
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
            Assert.That(_constructor.WebsiteHomePage.HomePageWelcomeMessage,
                Is.EqualTo("Fresh milk and groceries delivered plastic free"));
        }

        [When(@"I input a valid postcode")]
        [When(@"The service is avaiable in my area")]
        [When(@"I click the Find button")]
        public void InputValidPostcode()
        {
            _constructor.WebsiteHomePage.EnterAvailableValidPostcode("LS20 8JN");
        }

        [Then(@"I should be redirected to the registration page")]
        public void RedirectToRegistrationPage()
        {
            Assert.That(_constructor.WebsiteRegistrationPage.RegistrationPageWelcomeMessage,
                Is.EqualTo("Good news! We deliver in your area."));
        }
    }
}

