using NUnit.Framework;
using AutomationTestFramework.Library;
using TechTalk.SpecFlow;

namespace AutomationTestFramework.Tests.SteppingFunctions
{
    [Binding]
    public class UpdateUserEmailSteps
    {
        private MainProjectConstructor _constructor;

        [Given(@"I am on account update page")]
        public void RedirectToAccountUpdatePage()
        {
            _constructor = new MainProjectConstructor("firefox");
            _constructor.WebsiteHomePage.VisitHomePage();
            _constructor.WebsiteHomePage.SignIn();
            _constructor.WebsiteLoginPage.UserLogin("07987654320", "adminPassword");
            _constructor.WebsiteUserHomePage.AccountSettings();
        }
        
        [When(@"I have entered an invalid email")]
        public void UpdateWithInvalidEmail()
        {
            _constructor.WebsiteUpdateAccountPage.EditEmailAddress("Invalid Email");
        }
        
        [Then(@"An error message should be displayed")]
        public void InvalidEmailErrorMessage()
        {
            Assert.That(_constructor.WebsiteUpdateAccountPage.EmailErrorCheck,
                Is.EqualTo("Please enter the valid email"));
        }
    }
}
