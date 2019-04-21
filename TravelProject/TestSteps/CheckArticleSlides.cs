using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TravelProject.Helper;
using TravelProject.Pages;

namespace TravelProject.TestSteps
{
    [Binding]
    public class DinamicSlider : BaseTestClass
    {
        UtilsPageObject utilsPageObject = new UtilsPageObject();
        MainPageObject mainPageObject = new MainPageObject();

        [Given(@"I have reahed travelex homepage")]
        public void GivenIHaveReahedTravelexHomepage()
        {
            driver.WaitForPageToLoad();
        }

        [Given(@"I have resized the browser window to (.*) px wide")]
        public void GivenIHaveResizedTheBrowserWindowToPxWide(int p0)
        {
            utilsPageObject.ResizeBrowserWindow(550, 420);
        }

        [Given(@"I have scrolled down to the first slider")]
        public void GivenIHaveScrolledDownToTheFirstSlider()
        {
            driver.ScrollToElement(mainPageObject.Find_FirstArticle());
        }

        [When(@"I slide two times to the left")]
        public void WhenISlideTwoTimesToTheLeft()
        {
            IWebElement slideArticle = mainPageObject.Find_FirstArticle();
            utilsPageObject.SlideAction();
            utilsPageObject.SlideAction();
        }

        [Then(@"the third slide should be displayed")]
        public void ThenTheThirdSlideShouldBeDisplayed()
        {
            string slideNumber = mainPageObject.Get_SlideNumber();
            Assert.AreEqual("3", slideNumber);
        }
    }
}
