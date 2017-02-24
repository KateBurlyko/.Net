using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace framework.DeserealizationData.SearchData
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
