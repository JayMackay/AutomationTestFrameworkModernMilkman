using NUnit.Framework;
using AutomationTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class DeliveryServiceUnvailableSteps
    {
        private MainProjectConstructor _constructor;

        //SERVICE UNAVAILABLE
        [Given(@"I have inputted a valid unavailable postcode")]
        public void ValidPostcode()
        {
            _constructor = new MainProjectConstructor("firefox");
            _constructor.WebsiteHomePage.VisitHomePage();
            Assert.That(_constructor.WebsiteHomePage.HomePageWelcomeMessage,
                Is.EqualTo("Fresh milk and groceries delivered plastic free"));
            _constructor.WebsiteHomePage.EnterUnavailableValidPostcode("WV8 1TZ");
        }

        [When(@"I input a postcode where the service is unavailable and click find")]
        public void WhenServiceIsUnvailable()
        {
            _constructor.WebsiteHomePage.SearchPostcode();
        }

        [Then(@"I should be redirected to the service unavailable page")]
        public void UnavailablePageRedirection()
        {
            Assert.That(_constructor.WebsiteServiceUnavailablePage.ServiceUnavailable(),
                Is.EqualTo("Sorry, we don't deliver in your area yet..."));
        }
    }
}
