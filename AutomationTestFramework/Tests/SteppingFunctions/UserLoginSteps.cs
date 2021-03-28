using NUnit.Framework;
using AutomationTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class UserLoginSteps
    {
        private MainProjectConstructor _constructor;

        [Given(@"I am on the login page")]
        public void RedirectLoginPage()
        {
            _constructor = new MainProjectConstructor("firefox");
            _constructor.WebsiteHomePage.VisitHomePage();
            _constructor.WebsiteHomePage.SignIn();
            Assert.That(_constructor.WebsiteLoginPage.LoginHeaderCheck(),
                Is.EqualTo("Login"));
        }

        [When(@"I have entered all the correct login details")]
        public void LoginDetails()
        {
            _constructor.WebsiteLoginPage.UserLogin("07987654320", "adminPassword");
        }

        [Then(@"I should be redirected to the user account page")]
        public void UserAccountPageCheck()
        {
            Assert.That(_constructor.WebsiteUserHomePage.UserMilkDeliveryCheck(),
                Is.EqualTo("Milk"));
        }
    }
}