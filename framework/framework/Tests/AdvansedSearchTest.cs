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
            for(int i = 0; i<keywords.Count; i++)
            {
                keywords
            }
            asp.InputKeywords(keywords.);
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
