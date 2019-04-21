using OpenQA.Selenium;
using TravelProject.Helper;

namespace TravelProject.Pages
{
    class MainPageObject : BasePageObject
    {
        /// <summary>
        /// Finds the first section from the page
        /// </summary>
        /// <returns></returns>
        private IWebElement Find_FirstSectionArticle()
        {
            IWebElement firstSection = driver.FindElementExtended(By.ClassName("full-lb"));
            return firstSection;
        }

        /// <summary>
        /// Finds the first article from the page
        /// </summary>
        /// <returns></returns>
        public IWebElement Find_FirstArticle()
        {
           IWebElement firstArticle = Find_FirstSectionArticle().FindElement(By.ClassName("draggable"));
            return firstArticle;

        }

        /// <summary>
        /// Gets the number of the active slide 
        /// </summary>
        /// <returns></returns>
        public string Get_SlideNumber()
        {
            IWebElement articleSlides = Find_FirstSectionArticle().FindElement(By.ClassName("slick-dots"));
            IWebElement thirdSlide = articleSlides.FindElement(By.ClassName("slick-active"));

            return thirdSlide.Text;
        }
    }
}
