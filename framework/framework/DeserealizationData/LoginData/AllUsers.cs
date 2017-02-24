using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace framework.DeserealizationData.LoginData
{
    [Serializable]
    public class AllUsers
    {
        [XmlElement("user")]
        public List<User> Users { get; set; }        
    }
}
