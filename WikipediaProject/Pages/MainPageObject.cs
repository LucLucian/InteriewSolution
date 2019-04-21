using OpenQA.Selenium;
using WikipediaProject.Helper;

namespace WikipediaProject.Pages
{
    class MainPageObject : BasePageObject
    {
        /// <summary>
        /// Waits for a specific element on the page to be displayed
        /// </summary>
        public void WaitPageTitleIsDisplayed()
        {
            driver.FindElementExtended(By.ClassName("central-textlogo"));
        }

        /// <summary>
        /// Gets the main title of the loaded page
        /// </summary>
        /// <returns></returns>
        public string GetTitleText()
        {
            IWebElement pageTitle = driver.FindElementExtended(By.ClassName("central-textlogo"));
            string titleText = pageTitle.GetAttribute("title");

            return titleText;
        }

        /// <summary>
        /// Uses the search box to search for a specific text
        /// </summary>
        /// <param name="searchedText"></param>
        public void SearchBox(string searchedText)
        {
            IWebElement searchBox = driver.FindElementExtended(By.Id("searchInput"));
            searchBox.SendKeys(searchedText);
        }

        /// <summary>
        /// Clicks on the Search button from Wikipedia Home page
        /// </summary>
        public void Click_SearchButton()
        {
            driver.FindElementExtended(By.ClassName("pure-button")).Click();
        }
    }
}
