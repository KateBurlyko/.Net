using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using framework.Login;
using framework.Search;

namespace framework.Parser
{
    class CSVParser
    {
        public List<LoginData> GetLogin()
        {
            string[] login = File.ReadAllLines(Data.Default.loginPath);
            List<LoginData> list = new List<LoginData>();
            for (int i = 1; i < login.Length; i++)
            {
                string[] split = login[i].Split(new char[] { ',' });
                list.Add(new LoginData(split[0], split[1], split[2]));
            }
            return list;
        }

        public List<BaseSearch> GetSearcgQuery()
        {
            string[] login = File.ReadAllLines(Data.Default.SearchPath);
            List<BaseSearch> list = new List<BaseSearch>();
            for (int i = 1; i < login.Length; i++)
            {
                string[] split = login[i].Split(new char[] { ',' });
                list.Add(new BaseSearch(split[0].Replace(" ", "+"), split[1]));
            }
            return list;
        }

        public List<AdvansedSearch> GetAdvancedSearchInfo()
        {
            AdvansedSearch adv = new AdvansedSearch();
            string[] login = File.ReadAllLines(Data.Default.AdvancedSearchHome);
            List<AdvansedSearch> list = new List<AdvansedSearch>();
            for (int i = 0; i < login.Length; i++)
            {
                string word = login[i].Trim(new char[] { ',' });
                switch (word)
                {
                    case "keywords":
                        while (!login[i + 1].Equals("contentTypes"))
                        {
                            string[] split = login[i].Split(new char[] { ',' });
                            if (!split[2].Equals(null))
                            {
                                adv.Keywords.Add(split[0], split[1]);
                                adv.KeywordsContent.Add(split[1], split[2]);
                            }
                            i++;
                        }
                        break;
                    case "contentTypes":
                        while (!login[i + 1].Equals("PublicationDates"))
                        {
                            string[] split = login[i].Split(new char[] { ',' });
                            if (!split[1].Equals("null"))
                            {
                                adv.ContentTypes.Add(true, split[0]);
                            }
                            i++;
                        }
                        break;
                    case "PublicationDates":
                        while (!login[i + 1].Equals(null))
                        {
                            string[] split = login[i].Split(new char[] { ',' });
                            if (!split[1].Equals("null"))
                            {
                                adv.PublicationDates.Add(true, split[0]);
                            }
                            i++;
                        }
                        break;
                }

            }
            list.Add(adv);
            return list;
        }
    }
}