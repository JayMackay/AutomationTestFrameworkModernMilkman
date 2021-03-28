using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using System;

namespace AutomationTestFramework.ConfigurationFiles
{
    public class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driverName, int pageLoadWaitInSecs, int implicitWaitTimeInSecs)
        {
            DriverSetUp(driverName, pageLoadWaitInSecs, implicitWaitTimeInSecs);
        }

        private void DriverSetUp(string driverName, int pageLoadWaitInSecs, int implicitWaitTimeInSecs)
        {
            if (driverName.ToLower() == "chrome")
            {
                SetChromeDriver();
                SetDriverConfiguration(pageLoadWaitInSecs, implicitWaitTimeInSecs);
            }
            if (driverName.ToLower() == "firefox")
            {
                SetFirefoxDriver();
                SetDriverConfiguration(pageLoadWaitInSecs, implicitWaitTimeInSecs);
            }
            else
            {
                throw new Exception("Please use Chrome or Firefox as the driver argument");
            }
        }

        public void SetChromeDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
        }

        public void SetFirefoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        public void SetDriverConfiguration(int pageLoadWaitInSecs, int implicitWaitTimeInSecs)
        {
            //The is the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadWaitInSecs);
            //This is the time the driver waits for element before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTimeInSecs);
        }
    }
}
