using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;
using OpenQA.Selenium.Interactions;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class RegistrationPage
    {
        private IWebDriver _driver;
        private string registrationPageUrl = AppConfigReader.RegistrationPageUrl;

        //Page Elements
        private IWebElement WelcomeMessage => this._driver.FindElement(By.XPath("/html/body/section[@class='signup-page']/h1"));
        private IWebElement FirstNameInput => this._driver.FindElement(By.Id("forename"));
        private IWebElement SurnameInput => this._driver.FindElement(By.Id("surname"));
        private IWebElement EmailInput => this._driver.FindElement(By.Id("email"));
        private IWebElement ConfirmEmailInput => this._driver.FindElement(By.Id("email1"));
        private IWebElement PhoneNumberInput => this._driver.FindElement(By.Id("phoneNo"));
        private IWebElement PasswordInput => this._driver.FindElement(By.Id("password"));
        private IWebElement TermsCheck => this._driver.FindElement(By.XPath("/html/body/section[@class='signup-page']/div[@class='container']/div[@class='row']/div[@class='col-md-12']/div[@class='signup-form']/form[@id='signup']/div[@class='row spacing']/div[@class='col-md-12 spacing1'][2]/div[@class='custom-control custom-checkbox']/label[@class='custom-control-label']"));
        private IWebElement CreateAccountButton => this._driver.FindElement(By.XPath("/html/body/section[@class='signup-page']/div[@class='container']/div[@class='row']/div[@class='col-md-12']/div[@class='sencontinuebtn']/button[@id='addCustomer']/img[@class='create_account_button']/@src"));
        private IWebElement InvalidFormCheck => this._driver.FindElement(By.Id("swal2-content"));

        //Page Object Model Constructor
        public RegistrationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public void VisitRegistrationPage()
        {
            _driver.Navigate().GoToUrl(registrationPageUrl);
        }

        public string RegistrationPageWelcomeMessage()
        {
            return WelcomeMessage.Text;
        }

        public void RegisterNewUser(string firstName, string surname, string email, string confirmEmail, string phoneNumber, string password)
        {
            Actions action = new Actions(_driver); //Initializes Selenium interactions

            //User form input
            FirstNameInput.SendKeys(firstName);
            SurnameInput.SendKeys(surname);
            EmailInput.SendKeys(email);
            ConfirmEmailInput.SendKeys(confirmEmail);
            PhoneNumberInput.SendKeys(phoneNumber);
            PasswordInput.SendKeys(password);
            TermsCheck.Click();
            //action.MoveToElement(TermsCheck).MoveByOffset(5, 0).Click();
            CreateAccountButton.Click();
        }

        public bool BadEmailInput()
        {
            if (InvalidFormCheck.Enabled)
            {
                return true;
            }
            return false;
        }
    }
}
