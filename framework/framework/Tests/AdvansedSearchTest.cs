using framework.DeserealizationData.AdvansedSearch;
using framework.PageObject;
using NUnit.Framework;
using System.Collections.Generic;
using static framework.Tests.DataProviders;

namespace framework.Tests
{
    [TestFixture]
    class AdvansedSearchTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "AdvansedSearchData")]
        public static void AdvanseSearchTest(List<ContentTypes> contentTypes, List<PublicationDates> dates, List<Keywords> keywords)
        {
            AdvansedSearchPage asp = new AdvansedSearchPage();
            AdderTitles addTitles = new AdderTitles();
            AdderTypesAndLimits adder = new AdderTypesAndLimits();
            List<TitleItems> items = addTitles.AddTitles(keywords);
            List<ContentItems> limits = adder.AddLimits(contentTypes);
            List<ContentItems> types = adder.AddTitles(contentTypes);
            asp.Navigate();
            foreach (TitleItems ti in items)
            {
                asp.InputKeywords(ti.IdTitle, ti.Title);
            }
            foreach (ContentItems ct in types)
            {
                asp.ChoseContentTypes(ct.TypesAndLimits);
            }
            foreach (ContentItems ct in limits)
            {
                asp.ChooseLimitToContent(ct.TypesAndLimits);
            }
        }

        //[OneTimeTearDown]
        //public static void Cleanup()
        //{
        //    WebDriver.KillDriver();
        //}
    }
}
