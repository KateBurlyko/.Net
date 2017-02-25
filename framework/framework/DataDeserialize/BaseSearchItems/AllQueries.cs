using framework.DataDeserialize.baseSearchItems;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace framework.DataDeserialize.BaseSearchItems
{
   public class AllQueries
    {
        [XmlElement("query")]
        public List<Query> Queries { get; set; }

        public List<Query> GetQuery(AllQueries all)
        {
            List<Query> list = new List<Query>();
            for (int i = 0; i < all.Queries.Count; i++)
            {
                string[] split = all.Queries[i].Querys.ToString().Split(new char[] { ',' });
                list.Add(new Query(split[0].Replace(" ", "+"), all.Queries[i].Expected));
            }
            return list;
        }
    }
}
