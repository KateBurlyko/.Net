using framework.DataDeserialize.AdvansedSearchItems;
using framework.DataDeserialize.BaseSearchItems;
using framework.DataDeserialize.LoginItems;
using System.Xml;
using System.Xml.Serialization;

namespace framework.DataDeserialize
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

        public SearchParams DeserialiseAdvansedSearchQuery(string filePath)
        {
            var catalogSerialiser = new XmlSerializer(typeof(SearchParams));
            SearchParams quer = (SearchParams)catalogSerialiser.Deserialize(new XmlTextReader(filePath));
            return quer;
        }
    }
}
