using System.Configuration;

namespace AutomationTestFramework.ConfigurationFiles
{
    //Global reader for the App.config attributes
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string RegistrationPageUrl = ConfigurationManager.AppSettings["registrationpage_url"];
    }
}
