﻿using System;

namespace TravelProject.Pages
{
    class BasePageObject : DriverBase
    {
        internal const string URL_SEPARATOR = "/";
        internal const string DEFAULT_PROTOCOL = "https";

        /// <summary>
        ///     Navigates to the travelex home page 
        /// </summary>
        internal void GoToHomePage()
        {
            Uri homePageUrl = new Uri(string.Concat(DEFAULT_PROTOCOL, ":", URL_SEPARATOR, URL_SEPARATOR, "www.travelex.co.uk/"));
            driver.Navigate().GoToUrl(homePageUrl);
        }
    }
}