using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WikipediaProject.Helper;

namespace WikipediaProject.Pages
{
    class ArticlePageObject : BasePageObject
    {
        /// <summary>
        /// Gets by identifier and text, the article's Table of Content
        /// </summary>
        /// <returns></returns>
        public string Find_ArticleTableContent()
        {
            IWebElement tableContent = driver.WaitUntilElementIsAvailable(By.Id("toc"));
            return tableContent.Text;
        }

        /// <summary>
        /// Gets by identifier and text, the article's intended title
        /// </summary>
        /// <returns></returns>
        public string Find_ArticleTitle()
        {
            IWebElement articleTitle = driver.WaitUntilElementIsAvailable(By.Id("firstHeading"));
            return articleTitle.Text;
        }
    }
}
