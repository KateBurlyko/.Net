using Serialization2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serealization2
{
    class Deserealization
    {
        public Catalog DoDeserealization(XmlSerializer formatter, string path)
        {
            Catalog catalog = new Catalog();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                catalog = (Catalog)formatter.Deserialize(fs);
            }
            return catalog;
        }
    }
}
