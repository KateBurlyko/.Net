using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace framework.DeserealizationData.AdvansedSearch
{
    [Serializable]
   public class SearchParams
    {
        [XmlElement("SearchItems")]
        public List<SearchItems> Items { get; set; }
    }
}
