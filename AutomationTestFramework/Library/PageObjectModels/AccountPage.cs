using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class AccountPage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement AccountDetailHeader => this._driver.FindElement(By.XPath("/html/body/section[1]/div/div/div[1]/div/h2[1]"));
        private IWebElement EditAccountButton => this._driver.FindElement(By.XPath("/html/body/section[1]/div/div/div[2]/div/div[2]/a[1]/img"));

        //Page Object Model Constructor
        public AccountPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public string AccountDetailHeaderText()
        {
            return AccountDetailHeader.Text;
        }

        public void EditAccount()
        {
            EditAccountButton.Click();
        }
    }
}
