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
    class Serealization
    {
        public void DoSerealization(Catalog catalog, XmlSerializer formatter, string path)
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                formatter.Serialize(writer, catalog);
            }
        }
    }
}
