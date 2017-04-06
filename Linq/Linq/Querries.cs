using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Linq
{
    class Querries
    {
        public XDocument xDoc = XDocument.Load(Resource1.XmlPath);
        public IEnumerable<XElement> allCustomers;

        public void SecondQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         orderby customer.Element("country").Value
                         select customer;
            using (StreamWriter sw = new StreamWriter(Resource1.Querry2, false, Encoding.Default))
            {
                foreach (var someCustomer in querry)
                {
                    sw.WriteLine(someCustomer.Element("country").Value + " " + someCustomer.Element("name").Value);
                }
            }
        }

        public void ThirdQuerry(double sumX)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         where customer.Elements("orders").Elements("order").Any(x => Double.Parse(x.Element("total").Value) > sumX)
                         select customer;

            using (StreamWriter sw = new StreamWriter(Resource1.Querry3, false, Encoding.Default))
            {
                sw.WriteLine("orders more than: " + sumX);
                foreach (var someCustomer in querry)
                {
                    sw.WriteLine(someCustomer.Element("name").Value);
                }
            }
        }
    }
}
