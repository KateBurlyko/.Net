using framework.Tests.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using static framework.Tests.DataProviders;

namespace framework.mustransme
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    class SearchTests
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "SearchData")]
        public static void searchTest(string query, string expected)
        {
            BaseSearchPage searchPage = new BaseSearchPage();

            searchPage.Navigation(query);
            Assert.True(searchPage.FindSearchResults(expected));
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
