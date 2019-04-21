using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace TravelProject.Helper
{
    internal static class DriverExtension
    {
        private const int TIMEOUT = 30;

        /// <summary>
        /// Waits until element is available
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="timeToWait"></param>
        /// <returns></returns>
        internal static IWebElement WaitUntilElementIsAvailable(this IWebDriver driver, By by, int timeToWait = TIMEOUT)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

            Console.WriteLine($"Finding clickable element: {by}");
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(by));

            return element;
        }

        /// <summary>
        /// Wait for the launched page to be fully loaded
        /// </summary>
        /// <param name="driver"></param>
        internal static void WaitForPageToLoad(this IWebDriver driver)
        {
            TimeSpan timeout = new TimeSpan(0, 0, 20);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(wd => (wd as IJavaScriptExecutor)?.ExecuteScript("return document.readyState").ToString() == "complete");
        }

        /// <summary>
        /// Find an element, waiting until a timeout is reached if necessary
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <returns></returns>
        public static IWebElement FindElementExtended(this IWebDriver driver, By by)
        {
            return WaitUntilElementIsAvailable(driver, @by);
        }

        /// <summary>
        /// Scrolls to view.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="element">The element.</param>
        internal static void ScrollToElement(this IWebDriver driver, IWebElement element)
        {
            string js = $"window.scrollTo({element.Location.X}, {element.Location.Y})";
            driver.ExecuteJavaScript<string>(js);
        }
    }
}
