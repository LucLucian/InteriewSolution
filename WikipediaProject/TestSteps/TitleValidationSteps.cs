using NUnit.Framework;
using TechTalk.SpecFlow;
using WikipediaProject.Helper;
using WikipediaProject.Pages;
using WikipediaProject.TestSteps;

namespace WikipediaProject
{
    [Binding]
    public class TitleValidationSteps : BaseTestClass
    {
        MainPageObject mainPageObject = new MainPageObject();

        [Given(@"I have reached to Wikipedia Home page and waited for the page to be fully loaded")]
        public void GivenIHaveReachedToWikipediaHomePageAndWaitedForThePageToBeFullyLoaded()
        {
            driver.WaitForPageToLoad();
        }

        [When(@"I checked the Main title of the page")]
        public void WhenICheckedTheMainTitleOfThePage()
        {
            mainPageObject.WaitPageTitleIsDisplayed();
        }

        [Then(@"the title displayed should be ""(.*)""")]
        public void ThenTheTitleDisplayedShouldBe(string p0)
        {
            string titleText = mainPageObject.GetTitleText();
            Assert.AreEqual("Wikipedia", titleText);
        }
    }
}
