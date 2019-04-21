using System;

namespace WikipediaProject.Pages
{
    class BasePageObject : DriverBase
    {
        internal const string URL_SEPARATOR = "/";
        internal const string DEFAULT_PROTOCOL = "https";

        /// <summary>
        ///     Navigates to the wikipedia home page 
        /// </summary>
        internal void GoToHomePage()
        {
            Uri homePageUrl = new Uri(string.Concat(DEFAULT_PROTOCOL, ":", URL_SEPARATOR, URL_SEPARATOR, "www.wikipedia.org"));
            driver.Navigate().GoToUrl(homePageUrl);
        }
    }
}