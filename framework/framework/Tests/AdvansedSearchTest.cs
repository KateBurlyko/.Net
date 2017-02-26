using framework.DataDeserialize.AdvansedSearchItems;
using framework.DataDeserialize.AdvansedSearchItemsItems;
using framework.PageObject;
using NUnit.Framework;
using System.Collections.Generic;
using static framework.Tests.DataProviders;

namespace framework.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    class AdvansedSearchTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "AdvansedSearchData")]
        public static void AdvanseSearchTest(List<ContentTypes> contentTypes, List<PublicationDates> dates, List<Keywords> keywords)
        {
            AdvansedSearchPage asp = new AdvansedSearchPage();
            AdderTitles addTitles = new AdderTitles();
            AdderTypesAndLimits adder = new AdderTypesAndLimits();
            AdderDates add = new AdderDates();
            List<TitleItems> items = addTitles.AddTitles(keywords);
            List<ContentItems> limits = adder.AddLimits(contentTypes);
            List<ContentItems> types = adder.AddTitles(contentTypes);
            List<DateItems> dateItems = add.AddDates(dates);
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
            foreach (DateItems date in dateItems)
            {
                asp.ChosePublicationDate(date.Date);
            }
            asp.StartSearch();
            Assert.True(asp.FindSearchResults());
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
