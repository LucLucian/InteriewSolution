using NUnit.Framework;
using TechTalk.SpecFlow;
using WikipediaProject.Pages;

namespace WikipediaProject.TestSteps
{
    [Binding]
    public class SearchBoxSteps1 : BaseTestClass
    {
        MainPageObject mainPageObject = new MainPageObject();
        SearchResultPageObject searchResultPageObject = new SearchResultPageObject();

        [Given(@"I have searched for ""(.*)"" in the search box")]
        public void GivenIHaveSearchedForInTheSearchBox(string p0)
        {
            mainPageObject.SearchBox("furry rabbits");
            mainPageObject.Click_SearchButton();
        }
        
        [Given(@"I waited to get the searched results")]
        public void GivenIWaitedToGetTheSearchedResults()
        {
            string suggestionText = searchResultPageObject.Finds_SearchSuggestion();
            Assert.AreEqual("Did you mean: fury rabbit", suggestionText);
        }
        
        [When(@"I clicked on the ""(.*)"" suggestion")]
        public void WhenIClickedOnTheSuggestion(string p0)
        {
            searchResultPageObject.Click_SuggestionButton();
        }
        
        [Then(@"the page should contain  (.*) search results")]
        public void ThenThePageShouldContainSearchResults(int p0)
        {
            int numberRecords = searchResultPageObject.Get_NumberOfSearchResults();
            Assert.AreEqual(20, numberRecords);
        }
    }
}
