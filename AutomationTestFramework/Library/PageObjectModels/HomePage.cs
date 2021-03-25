using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class HomePage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement WelcomeMessage => this._driver.FindElement(By.XPath("/html/body/section[@class='opacitybnr1 banner-homepage']/div[@class='container']/div[@class='row']/div[@class='col-sm-12']/div[@class='banner-content']/h1"));
        private IWebElement PostcodeInput => this._driver.FindElement(By.Id("postcode"));
        private IWebElement FindButton => this._driver.FindElement(By.Id("checkPostcode5"));
        private IWebElement SignInButton => this._driver.FindElement(By.XPath("/img/images/Sign In Button.svg"));

        //Page Object Model Constructor
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(mainPageUrl);
        }

        public string HomePageWelcomeMessage()
        {
            return WelcomeMessage.Text;
        }

        public void EnterAvailableValidPostcode(string availablePostcode)
        {
            PostcodeInput.SendKeys(availablePostcode);
            FindButton.Click();
        }

        public void EnterUnavailableValidPostcode(string unavailablePostcode)
        {
            PostcodeInput.SendKeys(unavailablePostcode);
            FindButton.Click();
        }
    }
}
