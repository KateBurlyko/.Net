using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace framework.Tests.PageObject
{
    class BaseSearchPage
    {
        public object BaseSearch { get; private set; }

        public void Navigation(string query)
        {
            WebDriver.Driver.Navigate().GoToUrl($"http://journals.lww.com/pages/results.aspx?txtkeywords={query}");
        }

        public bool FindSearchResults(string text)
        {
            bool result = false;
            int size = WebDriver.Driver.FindElements(By.PartialLinkText(text)).Count;
            if (size > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
