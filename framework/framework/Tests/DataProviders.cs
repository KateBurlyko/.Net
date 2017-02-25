using framework.DataDeserialize;
using framework.DataDeserialize.AdvansedSearchItems;
using framework.DataDeserialize.baseSearchItems;
using framework.DataDeserialize.BaseSearchItems;
using framework.DataDeserialize.LoginItems;
using framework.JournalItem;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

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
                        yield return new TestCaseData(menu, menu.JournalTitle);
                    }
                }
            }

            public static IEnumerable NegativeLoginData()
            {
                Deserialization des = new Deserialization();
                AllUsers allUsers = des.DeserialiseLogInData(DesirialisationData.Default.loginPath);
                foreach (User all in allUsers.Users)
                {
                    yield return new TestCaseData(all.Login, all.Password, all.Expected);
                }
            }

            public static IEnumerable SearchData()
            {
                Deserialization des = new Deserialization();
                AllQueries all = des.DeserialiseSearchQuery(DesirialisationData.Default.searchData);
                List<Query> query = all.GetQuery(all);
                foreach (Query sin in query)
                {
                    yield return new TestCaseData(sin.Querys, sin.Expected);
                }
            }

            public static IEnumerable AdvansedSearchData()
            {
                Deserialization des = new Deserialization();
                SearchParams all = des.DeserialiseAdvansedSearchQuery(DesirialisationData.Default.advansedSearchData);
                foreach (SearchItems sin in all.Items)
                {
                    yield return new TestCaseData(sin.Contents, sin.Dates, sin.Keys);
                }
            }
        }
    }
}
