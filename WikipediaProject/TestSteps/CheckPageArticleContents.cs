using NUnit.Framework;
using TechTalk.SpecFlow;
using WikipediaProject.Pages;
using WikipediaProject.TestSteps;

namespace WikipediaProject
{
    [Binding]
    public class SearchResultsSteps : BaseTestClass
    {
        MainPageObject mainPageObject = new MainPageObject();
        SearchResultPageObject searchResultPageObject = new SearchResultPageObject();
        ArticlePageObject articlePageObject = new ArticlePageObject();

        [Given(@"I have entered ""(.*)"" text in the search box and waited for search results")]
        public void GivenIHaveEnteredTextInTheSearchBoxAndWaitedForSearchResults(string p0)
        {
            mainPageObject.SearchBox("furry rabbits");
            mainPageObject.Click_SearchButton();
        }

        [Given(@"I clicked on the ""(.*)"" link suggestion")]
        public void GivenIClickedOnTheLinkSuggestion(string p0)
        {
            searchResultPageObject.Click_SuggestionButton();
        }

        [When(@"I clicked on the first result i got on that suggestion")]
        public void WhenIClickedOnTheFirstResultIGotOnThatSuggestion()
        {
            searchResultPageObject.Click_FirstRecordSearched("Plymouth Gran ");
        }

        [Then(@"the page article should contain a standard wikipedia Title and a Table of content")]
        public void ThenThePageArticleShouldContainAStandardWikipediaTitleAndATableOfContent()
        {
            string titleText = articlePageObject.Find_ArticleTitle();
            Assert.AreEqual("Plymouth Gran Fury", titleText);

            string tableContent = articlePageObject.Find_ArticleTableContent();
            Assert.IsTrue(tableContent.Contains("Contents"));
        }
    }
}
