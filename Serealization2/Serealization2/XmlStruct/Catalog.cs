using Serealization2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization2
{
    [XmlRoot("catalog", Namespace = "http://library.by/catalog", IsNullable = false)]
    public class Catalog
    {
        private DateTime date;

        [XmlAttribute("date")]
        public string Date
        {
            get
            { return date.ToString("yyyy-MM-dd"); }
            set
            { date = DateTime.Parse(value); }
        }

        [XmlArray("books"), XmlArrayItem("book", typeof(Book))]
        public List<Book> Books { get; set; }
    }
}
