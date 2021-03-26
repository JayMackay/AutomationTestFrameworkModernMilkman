using NUnit.Framework;
using AutomationTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class DeliveryServiceAvailableSteps
    {
        private MainProjectConstructor _constructor;

        //SERVICE AVAILABLE
        [Given(@"I have inputted a valid available postcode")]
        public void ValidPostcode()
        {
            _constructor = new MainProjectConstructor("firefox");
            _constructor.WebsiteHomePage.VisitHomePage();
            Assert.That(_constructor.WebsiteHomePage.HomePageWelcomeMessage,
                Is.EqualTo("Fresh milk and groceries delivered plastic free"));
            _constructor.WebsiteHomePage.EnterAvailableValidPostcode("LS20 8JN");
        }

        [When(@"I input a postcode where the service is available and click find")]
        public void WhenServiceIsAvailable()
        {
            _constructor.WebsiteHomePage.SearchPostcode();
        }

        [Then(@"I should be redirected to the registration page")]
        public void RegistrationPageRedirection()
        {
            Assert.That(_constructor.WebsiteRegistrationPage.RegistrationPageWelcomeMessage,
                Is.EqualTo("Good news!\r\nWe deliver in your area."));
        }
    }
}
