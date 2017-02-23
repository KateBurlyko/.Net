using framework.Parser;
using framework.Search;
using framework.Tests.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using static framework.Tests.DataProviders;

namespace framework.mustransme
{
    [TestFixture]
    [Parallelizable]//(ParallelScope.Fixtures)]
    class SearchTests
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCaseSearch")]
        public static void searchTest(BaseSearch query)
        {
            SearchPage searchPage = new SearchPage();

            searchPage.Navigation(query.Query);
            Assert.True(searchPage.FindSearchResults(query.Expected));
        }

        [Test]
        public static void advansedSearchTest()
        {

            CSVParser par = new CSVParser();
            List<AdvansedSearch> list = par.GetAdvancedSearchInfo();
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/pages/advancedsearch.aspx");
            //WebDriver.Driver.FindElement(By.LinkText("Last 3 Years")).Click();
            
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
