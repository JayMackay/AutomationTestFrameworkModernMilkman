using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class HomePage
    {
        private IWebDriver driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        private IWebElement PostcodeInput => this.driver.FindElement(By.Id("postcode"));
        private IWebElement FindButton => this.driver.FindElement(By.Id("checkPostcode5"));
        private IWebElement SignInButton => this.driver.FindElement(By.XPath("/img/images/Sign In Button.svg"));
    }
}
