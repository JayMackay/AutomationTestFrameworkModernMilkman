using NUnit.Framework;
using AutomationTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class PostcodeValidationTestSteps
    {
        private MainProjectConstructor _constructor;

        [Given(@"I have inputted a valid postcode")]
        public void GivenIHaveInputtedAValidPostcode()
        {
            _constructor = new MainProjectConstructor("firefox");
            _constructor.WebsiteHomePage.VisitHomePage();
            Assert.That(_constructor.WebsiteHomePage.HomePageWelcomeMessage,
                Is.EqualTo("Fresh milk and groceries delivered plastic free"));
            _constructor.WebsiteHomePage.EnterAvailableValidPostcode("LS20 8JN");
        }

        [When(@"I click the Find button")]
        public void WhenIClickTheFindButton()
        {
            _constructor.WebsiteHomePage.SearchPostcode();
        }

        [Then(@"I should be redirected to the registration page")]
        public void ThenIShouldBeRedirectedToTheRegistrationPage()
        {
            Assert.That(_constructor.WebsiteRegistrationPage.RegistrationPageWelcomeMessage,
                Is.EqualTo("Good news! We deliver in your area."));
        }
    }
}
