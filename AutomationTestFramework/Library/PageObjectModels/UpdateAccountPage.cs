using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class UpdateAccountPage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement SaveButton => this._driver.FindElement(By.Id("update_profile"));
        private IWebElement EmailAddressInput => this._driver.FindElement(By.Id("email"));
        private IWebElement ValidEmailErrorMessage => this._driver.FindElement(By.Id("error-otp"));

        //Page Object Model Constructor
        public UpdateAccountPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public void EditEmailAddress(string newEmail)
        {
            EmailAddressInput.SendKeys(newEmail);
        }

        public void SaveUpdate()
        {
            SaveButton.Click();
        }

        public string EmailErrorCheck()
        {
            return ValidEmailErrorMessage.Text;
        }
    }
}

