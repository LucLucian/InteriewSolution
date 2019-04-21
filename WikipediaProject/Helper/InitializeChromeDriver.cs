using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WikipediaProject.Helper
{
    public static class InitializeChromeDriver
    {
        /// <summary>
        /// Starts the chrome driver
        /// </summary>
        /// <returns></returns>
        internal static IWebDriver StartChromeDriver()
        {
            IWebDriver driver;
            driver = StartDesktopChromeBrowser();
            driver.Manage().Window.Maximize();
            return driver;
        }

        /// <summary>
        /// Starts the desktop chrome browser
        /// </summary>
        /// <returns></returns>
        private static IWebDriver StartDesktopChromeBrowser()
        {
            IWebDriver driver;
            driver = new ChromeDriver(Environment.CurrentDirectory);

            return driver;
        }
    }
}

