using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement LoginHeaderString => this._driver.FindElement(By.XPath("/html/body/section[1]/div/div/div/div/h1"));
        private IWebElement MobileNumberInput => this._driver.FindElement(By.Id("phoneNo"));
        private IWebElement PasswordInput => this._driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => this._driver.FindElement(By.Id("btn_submit"));

        //Page Object Model Constructor
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public string LoginHeaderCheck()
        {
            return LoginHeaderString.Text;
        }

        public void UserLogin(string username, string password)
        {
            MobileNumberInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }
    }
}