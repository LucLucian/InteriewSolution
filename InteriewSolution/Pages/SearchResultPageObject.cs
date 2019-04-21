using OpenQA.Selenium;
using System.Collections.Generic;
using WikipediaProject.Helper;

namespace WikipediaProject.Pages
{
    class SearchResultPageObject : BasePageObject
    {
        /// <summary>
        /// Identifies the Did You Mean suggestion element
        /// </summary>
        public string Finds_SearchSuggestion()
        {
            IWebElement suggestionElement = driver.FindElementExtended(By.ClassName("searchdidyoumean"));
            return suggestionElement.Text;
        }

        public string Finds_SearchResultTitle()
        {
            IWebElement searchResultTitle = driver.WaitUntilElementIsAvailable(By.Id("firstHeading"));
            return searchResultTitle.Text;
        }

        public void Click_SuggestionButton()
        {
            driver.FindElementExtended(By.Id("mw-search-DYM-suggestion")).Click();
        }

        public int Get_NumberOfSearchResults()
        {
            IList<IWebElement> searchRecords = driver.FindElements(By.ClassName("mw-search-result"));
            return searchRecords.Count;
        }

        public void Click_FirstRecordSearched(string recordName)
        {
            UtilsPageObject utilsPageObject = new UtilsPageObject();
            utilsPageObject.SelectRecordRowByText(By.ClassName("mw-search-results"), recordName);
        }
    }
}
