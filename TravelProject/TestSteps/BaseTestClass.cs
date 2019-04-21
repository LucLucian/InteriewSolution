using TechTalk.SpecFlow;
using TravelProject.Helper;
using TravelProject.Pages;

namespace TravelProject.TestSteps
{
    public class BaseTestClass : DriverBase
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            StartWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseDriver();
        }

        public void CloseDriver()
        {
            try
            {
                driver?.Quit();
                driver = null;
            }
            catch
            {
            }
        }

        public void StartWebDriver()
        {
            if( driver == null )
            {
                driver = InitializeChromeDriver.StartChromeDriver();
            }
            BasePageObject basePageObject = new BasePageObject();
            basePageObject.GoToHomePage();
            driver.WaitForPageToLoad();
        }
    }
}
