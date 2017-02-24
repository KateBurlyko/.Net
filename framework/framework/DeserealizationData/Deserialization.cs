using framework.DeserealizationData.LoginData;
using framework.DeserealizationData.SearchData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace framework.DeserealizationData
{
    class Deserialization
    {
        public AllUsers DeserialiseLogInData(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(AllUsers));
            AllUsers all = (AllUsers)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
            return all;
        }

        public AllQueries DeserialiseSearchQuery(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(AllQueries));
            AllQueries quer = (AllQueries)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
            return quer;
        }
    }
}
