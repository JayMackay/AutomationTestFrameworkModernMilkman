using AutomationTestFramework.ConfigurationFiles;
using AutomationTestFramework.Library.PageObjectModels;
using OpenQA.Selenium;

namespace AutomationTestFramework.Library
{
    public class MainProjectConstructor
    {
        //Accessible Read Only Page Object Models
        public readonly HomePage WebsiteHomePage;
        public readonly RegistrationPage WebsiteRegistrationPage;
        public readonly ServiceUnavailablePage WebsiteServiceUnavailablePage;
        public readonly UserHomePage WebsiteUserHomePage;
        public readonly LoginPage WebsiteLoginPage;
        public readonly AccountPage WebsiteAccountPage;
        public readonly UpdateAccountPage WebsiteUpdateAccountPage;
        public readonly IWebDriver seleniumDriver;

        //Constructor For Driver & Configurations For The Service
        public MainProjectConstructor(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            //Instantiation Of Driver
            seleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            //Instantiation Of Page Objects With The Selenium Driver
            WebsiteHomePage = new HomePage(seleniumDriver);
            WebsiteRegistrationPage = new RegistrationPage(seleniumDriver);
            WebsiteServiceUnavailablePage = new ServiceUnavailablePage(seleniumDriver);
            WebsiteUserHomePage = new UserHomePage(seleniumDriver);
            WebsiteLoginPage = new LoginPage(seleniumDriver);
            WebsiteAccountPage = new AccountPage(seleniumDriver);
            WebsiteUpdateAccountPage = new UpdateAccountPage(seleniumDriver);
        }
    }
}
