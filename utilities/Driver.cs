using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Threading;


namespace csharp_cucumber_selenium_framework.utilities
{
    public class Driver
    {
        private static readonly ThreadLocal<IWebDriver> driverPool = new ThreadLocal<IWebDriver>();

        private Driver() { }

        public static IWebDriver GetDriver()
        {
            if (driverPool.Value == null)
            {
                string browserType = Environment.GetEnvironmentVariable("BROWSER") ?? ConfigurationReader.GetProperty("browser");
                Console.WriteLine($"Browser Type : {browserType}");

                switch (browserType.ToLower())
                {
                    case "chrome":
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments("--lang=en-GB", "--disable-notifications", "--disable-extensions", "--ignore-certificate-errors");
                        driverPool.Value = new ChromeDriver(chromeOptions);
                        break;

                    case "firefox":
                        FirefoxOptions firefoxOptions = new FirefoxOptions();
                        firefoxOptions.Profile = new FirefoxProfile();
                        firefoxOptions.Profile.SetPreference("intl.accept_languages", "en-GB");
                        driverPool.Value = new FirefoxDriver(firefoxOptions);
                        break;

                    case "safari":
                        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                        {
                            throw new WebDriverException("Your operating system does not support the SAFARI browser");
                        }
                        driverPool.Value = new SafariDriver();
                        break;

                    default:
                        throw new ArgumentException($"Unsupported browser type: {browserType}");
                }

                driverPool.Value.Manage().Window.Maximize();
                driverPool.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

            return driverPool.Value;
        }

        public static void CloseDriver()
        {
            if (driverPool.Value != null)
            {
                driverPool.Value.Quit();
                driverPool.Value = null;
            }
        }
    }
}
