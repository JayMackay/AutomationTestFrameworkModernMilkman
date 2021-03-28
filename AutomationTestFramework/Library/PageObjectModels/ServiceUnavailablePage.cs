using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class ServiceUnavailablePage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement ServiceUnavailableMessage => this._driver.FindElement(By.XPath("/html/body/section[@class='signup-page']/h1"));

        //Page Object Model Constructor
        public ServiceUnavailablePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public string ServiceUnavailable()
        {
            return ServiceUnavailableMessage.Text;
        }
    }
}
