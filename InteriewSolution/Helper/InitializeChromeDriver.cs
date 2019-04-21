using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WikipediaProject.Helper
{
    public static class InitializeChromeDriver
    {

        internal static IWebDriver StartChromeDriver()
        {
            IWebDriver driver;
            driver = StartDesktopChromeBrowser();
            return driver;
        }

        private static IWebDriver StartDesktopChromeBrowser()
        {
            IWebDriver driver;
            ChromeOptions chromeOptions = SetDriverOptions();
            driver = new ChromeDriver(Environment.CurrentDirectory);

            return driver;
        }

        private static ChromeOptions SetDriverOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");

            return chromeOptions;
        }
    }
}

