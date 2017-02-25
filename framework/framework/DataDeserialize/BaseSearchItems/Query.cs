using System.Xml.Serialization;

namespace framework.DataDeserialize.baseSearchItems
{
   public class Query
    {
        [XmlElement("query")]
        public string Querys { get; set; }

        [XmlElement("expected")]
        public string Expected { get; set; }

        public Query(string query, string expected)
        {
            Querys = query;
            Expected = expected;
        }

        public Query() { }
    }
}
