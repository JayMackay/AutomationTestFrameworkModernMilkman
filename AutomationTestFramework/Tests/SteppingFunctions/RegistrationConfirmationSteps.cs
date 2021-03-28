using NUnit.Framework;
using AutomationTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class RegistrationConfirmationSteps
    {
        private MainProjectConstructor _constructor;

        [Given(@"I am on the registration page for a new user")]
        public void RegistrationPage()
        {
            _constructor = new MainProjectConstructor("firefox");
            _constructor.WebsiteHomePage.VisitHomePage();
            _constructor.WebsiteHomePage.EnterAvailableValidPostcode("LS20 8JN");
            _constructor.WebsiteHomePage.SearchPostcode();
            Assert.That(_constructor.WebsiteRegistrationPage.RegistrationPageWelcomeMessage(),
                Is.EqualTo("Good news!\r\nWe deliver in your area."));
        }

        [When(@"I have entered all the correct details within the form")]
        public void SignupForm()
        {
            _constructor.WebsiteRegistrationPage.RegisterNewUser(
                "NewTestUserFirstName",
                "NewTestUserSurname",
                "admin.test@mail.com",
                "admin.test@mail.com",
                "07987654322",
                "Password");
        }

        [Then(@"I should be logged in as new user")]
        public void NewUserLogin()
        {
            Assert.That(_constructor.WebsiteUserHomePage.UserMilkDeliveryCheck(),
                Is.EqualTo("Milk"));
        }
    }
}