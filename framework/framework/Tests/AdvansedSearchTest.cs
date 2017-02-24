using framework.DeserealizationData.AdvansedSearch;
using framework.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static framework.Tests.DataProviders;

namespace framework.Tests
{
    [TestFixture]
    class AdvansedSearchTest
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "AdvansedSearchData")]
        public static void AdvanseSearchTest(List<Keywords> keywords, List<ContentTypes> contentTypes, List<PublicationDates> dates)
        {
            AdvansedSearchPage asp = new AdvansedSearchPage();
            foreach (Keywords ke in keywords) {
                asp.InputKeywords(keywords.);

                List<string> somedata = new List<string>();
                somedata.Add(ke.Abstract);

                    }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
