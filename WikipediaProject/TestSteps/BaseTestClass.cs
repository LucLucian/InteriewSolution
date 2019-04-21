using TechTalk.SpecFlow;
using WikipediaProject.Helper;
using WikipediaProject.Pages;

namespace WikipediaProject.TestSteps
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
