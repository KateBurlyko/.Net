using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace framework.DeserealizationData.AdvansedSearch
{
    [Serializable]
    public class SearchItems
    {
        [XmlElement("Keywords")]
        public List<Keywords> Keys { get; set; }

        [XmlElement("ContentTypes")]
        public List<ContentTypes> Contents { get; set; }

        [XmlElement("PublicationDates")]
        public List<PublicationDates> Dates { get; set; }
    }
}
