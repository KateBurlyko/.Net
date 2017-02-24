using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace framework.DeserealizationData.AdvansedSearch
{
    [Serializable]
   public class Keywords
    {
        [XmlElement("allFields")]
        public string AllFields { get; set; }

        [XmlAttribute("idAllFields")]
        public int IDAllFields { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlAttribute("idTitle")]
        public int IDTitle { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlAttribute("idAuthor")]
        public int IDAuthor { get; set; }

        [XmlElement("abstract")]
        public string Abstract { get; set; }

        [XmlAttribute("idAbstract")]
        public int IDAbstract { get; set; }

        [XmlElement("fullText")]
        public string FullText { get; set; }

        [XmlAttribute("idFullText")]
        public int IDFullText { get; set; }

        [XmlElement("volume")]
        public string Volume { get; set; }

        [XmlAttribute("idVolume")]
        public int IDVolume { get; set; }

        [XmlElement("issue")]
        public string Issue { get; set; }

        [XmlAttribute("idIssue")]
        public int IDIssue { get; set; }
    }

    [Serializable]
    public class LimitToContentWith
    {
        [XmlElement("cmeCE")]
        public string CmeCE { get; set; }

        [XmlElement("SDC")]
        public string SDC { get; set; }
    }

    [Serializable]
    public class ContentTypes
    {
        [XmlElement("articles")]
        public string Articles { get; set; }

        [XmlElement("images")]
        public string Images { get; set; }

        [XmlElement("podcast")]
        public string Podcast { get; set; }

        [XmlElement("videos")]
        public string Videos { get; set; }

        [XmlElement("blogs")]
        public string Blogs { get; set; }

        [XmlElement("LimitToContentWith")]
        public List<LimitToContentWith> ContentLimits { get; set; }
    }

    [Serializable]
    public class PublicationDates
    {      
            [XmlElement("allDates")]
        public string AllDates { get; set; }

        [XmlElement("twelveMounth")]
        public string TwelveMounth { get; set; }

        [XmlElement("threeYears")]
        public string ThreeYears { get; set; }

        [XmlElement("fiveYears")]
        public string FiveYears { get; set; }

        [XmlElement("eightYears")]
        public string EightYears { get; set; }
    }
}
