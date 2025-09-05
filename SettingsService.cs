using MyDotNetHub.Models;

namespace MyDotNetHub.Services
{
    public class SettingsService
    {
        public AppSettings GetSettingsByAppVersionNumber(string appVersionNumber)
        {
            if (string.IsNullOrEmpty(appVersionNumber))
            {
                return GetFallBackSettings();
            }

            switch (appVersionNumber)
            {
                case "1":
                    return GetSettingsForAppVersionNumber1();
                default:
                    return GetFallBackSettings();
            }
        }

        private AppSettings GetFallBackSettings()
        {
            AppSettings fallbackAppSettings = new AppSettings()
            {
                BackgroundColor = "#FFFFFF"
            };

            return fallbackAppSettings;
        }

        private AppSettings GetSettingsForAppVersionNumber1()
        {
            AppSettings fallbackAppSettings = new AppSettings()
            {
                BackgroundColor = "#F3F3F3"
            };

            return fallbackAppSettings;
        }
    }
}