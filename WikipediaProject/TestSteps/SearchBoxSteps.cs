using NUnit.Framework;
using TechTalk.SpecFlow;
using WikipediaProject.Pages;

namespace WikipediaProject.TestSteps
{
    [Binding]
    public class SearchBoxSteps : BaseTestClass
    {
        MainPageObject mainPageObject = new MainPageObject();
        SearchResultPageObject searchResultPageObject = new SearchResultPageObject();

        [Given(@"I have entered ""(.*)"" text in the search box")]
        public void GivenIHaveEnteredTextInTheSearchBox(string p0)
        {
            mainPageObject.SearchBox("furry rabbits");
        }
        
        [Given(@"I have pressed the search button")]
        public void GivenIHavePressedTheSearchButton()
        {
            mainPageObject.Click_SearchButton();
        }

        [When(@"I waited to get the searched results")]
        public void WhenIWaitedToGetTheSearchedResults()
        {
            string titleText = searchResultPageObject.Finds_SearchResultTitle();
            Assert.AreEqual("Search results", titleText);
        }
        
        [Then(@"the page should contain a ""(.*)"" suggestion")]
        public void ThenThePageShouldContainASuggestion(string p0)
        {
            string suggestionText = searchResultPageObject.Finds_SearchSuggestion();
            Assert.AreEqual("Did you mean: fury rabbit", suggestionText);
        }
    }
}
