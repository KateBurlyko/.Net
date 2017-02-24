using NUnit.Framework;
using Serialization2;
using System.Xml.Serialization;

namespace Serealization2
{
    [TestFixture]
    class SerealizationTest
    {
        [Test]
        public void DeserialiseTest()
        {
            Deserealization deserealize = new Deserealization();
            Serealization serealize = new Serealization();
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));
            Catalog catalog = deserealize.DoDeserealization(formatter, Data.Default.PathToRead);
            Assert.False(catalog.Equals(null));
        }

        [Test]
        public void SerialiseTest()
        {
            Deserealization deserealize = new Deserealization();
            Serealization serealize = new Serealization();
            FileWorker fw = new FileWorker();
            
            fw.Create(Data.Default.PathToWrite);
            long startSize = fw.GetSize(Data.Default.PathToWrite);
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));
            Catalog catalog = deserealize.DoDeserealization(formatter, Data.Default.PathToRead);
            serealize.DoSerealization(catalog, formatter, Data.Default.PathToWrite);
            long finishSize = fw.GetSize(Data.Default.PathToWrite);
           // fw.Delete(Data.Default.PathToWrite);
            Assert.IsTrue(finishSize>startSize);
        }
    }
}
