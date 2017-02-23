using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serealization2
{
    [Serializable]
    public class Book
    {
        private DateTime publishDate;
        private DateTime registrationDate;

        public Book() { }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public string Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDate
        {
            get
            { return publishDate.ToString("yyyy-MM-dd"); }
            set
            { publishDate = DateTime.Parse(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegestrationDate
        {
            get
            { return registrationDate.ToString("yyyy-MM-dd"); }
            set
            { registrationDate = DateTime.Parse(value); }
        }

        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }


        private static DateTimeFormatInfo GetFormat()
        {
            var format = new DateTimeFormatInfo { DateSeparator = "-", ShortDatePattern = "yyyy-MM-dd" };
            return format;
        }
    }

    //public enum Genre
    //{
    //    Computer,
    //    Fantasy,
    //    Romance,
    //    Horror,
    //    ScienceFiction
    //}
}