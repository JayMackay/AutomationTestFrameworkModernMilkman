using AutomationTestFramework.ConfigurationFiles;
using AutomationTestFramework.Library.PageObjectModels;
using OpenQA.Selenium;

namespace AutomationTestFramework.Library
{
    public class MainProjectConstructor
    {
        //Accessible read only page object models
        public readonly HomePage WebsiteHomePage;
        public readonly RegistrationPage WebsiteRegistrationPage;
        public readonly IWebDriver seleniumDriver;

        //Constructor for driver and configurations for the service
        public MainProjectConstructor(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            //Instatation of driver
            seleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            //Instantation of page objects with the selenium driver
            WebsiteHomePage = new HomePage(seleniumDriver);
            WebsiteRegistrationPage = new RegistrationPage(seleniumDriver);
        }
    }
}
