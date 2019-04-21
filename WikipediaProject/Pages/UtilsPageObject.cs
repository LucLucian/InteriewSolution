using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;

namespace WikipediaProject.Pages
{
    class UtilsPageObject : BasePageObject
    {
        /// <summary>
        /// Gets search record row by text
        /// </summary>
        /// <param name="ListIdentifier"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        protected internal IWebElement GetRecordRowByText(By ListIdentifier, string text)
        {
            IWebElement searchList = driver.FindElement(ListIdentifier);

            IWebElement foundElement = searchList.FindElements(By.TagName("li"))
               .FirstOrDefault(recordRow => recordRow.Text.ToLowerInvariant().Contains(text.ToLowerInvariant())).FindElement(By.TagName("a"));

            if (null == foundElement)
            {
                throw new Exception(string.Concat("Unable to find element with text: ", text, " by: ", ListIdentifier));
            }

            return foundElement;
        }

        /// <summary>
        /// Clicks on a search record row by text
        /// </summary>
        /// <param name="ListIdentifier"></param>
        /// <param name="text"></param>
        protected internal void SelectRecordRowByText(By ListIdentifier, string text)
        {
            IWebElement recordRow = GetRecordRowByText(ListIdentifier, text);

            recordRow.Click();

            Thread.Sleep(500);
        }
    }
}
