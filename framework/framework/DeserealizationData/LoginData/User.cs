using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace framework.DeserealizationData.LoginData
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