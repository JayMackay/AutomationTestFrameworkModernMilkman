using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class UserHomePage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement MilkDelivery => this._driver.FindElement(By.XPath("/html/body/section[2]/div/div/div/div[2]/div[1]/div/div/p/a"));
        private IWebElement ProfileDropDownMenu => this._driver.FindElement(By.XPath("/html/body/nav/div/div/div[2]/ul/li[1]/a"));
        private IWebElement MyAccountMenuCategory => this._driver.FindElement(By.XPath("/html/body/nav/div/div/div[2]/ul/li[1]/ul/li[5]/a"));


        //Page Object Model Constructor
        public UserHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Methods
        public string UserMilkDeliveryCheck()
        {
            return MilkDelivery.Text;
        }

        public void AccountSettings()
        {
            ProfileDropDownMenu.Click();
            MyAccountMenuCategory.Click();
        }

    }
}