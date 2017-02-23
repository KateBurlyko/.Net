using framework.JournalItem;
using framework.Parser;
using framework.Search;
using framework.Tests.PageObject;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Tests
{
    class DataProviders
    {
        public class TestCasesProvider
        {
            public static IEnumerable TestCaseWithJournals()
            {
                Journal journa = new Journal();
                AllJournals all = new AllJournals();
                WorkingWithExcel work = new WorkingWithExcel();

                List<Journal> list = work.GetJournalInfo(all, Data.Default.pathBatch, journa);
                foreach (Journal jou in list)
                {
                    foreach (MenuElement menu in jou.JournalInfo)
                    {
                        yield return new TestCaseData(menu);
                    }
                }
            }

            public static IEnumerable TestCaseSearch()
            {
                SearchPage sp = new SearchPage();
                CSVParser par = new CSVParser();
                List<BaseSearch> queryList = par.GetSearcgQuery();
                foreach (BaseSearch query in queryList)
                {
                    yield return new TestCaseData(query);
                }
            }
        }
    }
}
