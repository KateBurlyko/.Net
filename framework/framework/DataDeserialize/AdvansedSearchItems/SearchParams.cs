using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace framework.DataDeserialize.AdvansedSearchItems
{
    [Serializable]
    public class SearchParams
    {
        [XmlElement("SearchItems")]
        public List<SearchItems> Items { get; set; }
    }
}
