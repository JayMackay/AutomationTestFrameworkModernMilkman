using OpenQA.Selenium;
using AutomationTestFramework.ConfigurationFiles;

namespace AutomationTestFramework.Library.PageObjectModels
{
    public class UserHomePage
    {
        private IWebDriver _driver;
        private string mainPageUrl = AppConfigReader.BaseUrl;

        //Page Elements
        private IWebElement MilkDelivery => this._driver.FindElement(By.XPath("/html/body[@class='login']/section[@class='categories-section']/div[@class='container']/div[@class='row']/div[@class='col-sm-12']/div[@class='row']/div[@class='col-6 col-sm-3'][1]/div[@class='categries-singleblocks']/div[@class='single-categories-name']/p/a"));

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

    }
}