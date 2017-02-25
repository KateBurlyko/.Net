using System.Xml.Serialization;

namespace framework.DataDeserialize.LoginItems
{
    public class User
    {
        [XmlElement("login")]
        public string Login { get; set; }

        [XmlElement("password")]
        public string Password { get; set; }

        [XmlElement("expected")]
        public string Expected { get; set; }
    }
}