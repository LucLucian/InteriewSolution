using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing;
using System.Threading;
using TravelProject.Helper;

namespace TravelProject.Pages
{
    class UtilsPageObject : BasePageObject
    {
        /// <summary>
        /// Drags the mouse between two elements in order to slide through article
        /// </summary>
        public void SlideAction()
        {
            MainPageObject mainPageObject = new MainPageObject();

            Actions action = new Actions(driver);
            IWebElement firstElement = mainPageObject.Find_FirstArticle().FindElement(By.ClassName("slick-active")).FindElement(By.ClassName("red-button")).FindElement(By.TagName("span"));
            IWebElement secondElement = mainPageObject.Find_FirstArticle().FindElement(By.ClassName("slick-active")).FindElement(By.ClassName("inner-wrap"));
            action.ClickAndHold(firstElement).MoveToElement(secondElement).Release().Perform();

            Thread.Sleep(2000);
        }

        /// <summary>
        /// Resize the Browser Window to a specific size
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void ResizeBrowserWindow(int width, int height)
        {
            driver.Manage().Window.Size = new Size(width, height);
            Console.WriteLine(driver.Manage().Window.Size);
           
            if (driver.FindElementExtended(By.Id("_evh-ric-c")).Displayed)
            {
                driver.FindElementExtended(By.Id("_evh-ric-c")).Click();
            }
            else
            {
                //do nothing
            }
        }
    }
}
