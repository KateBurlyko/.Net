using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq
{
    class Querries
    {
        public XDocument xDoc = XDocument.Load(Resource1.XmlPath);
        public IEnumerable<XElement> allCustomers;

        public IEnumerable<XElement> FirstQuerry(double sumX)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         where customer.Element("orders").Elements("order").Sum(x => Double.Parse(x.Element("total").Value)) > sumX
                         select customer;
            return querry;
        }

        public IEnumerable<XElement> SecondQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         orderby customer.Element("country").Value
                         select customer;
            return querry;
        }

        public IEnumerable<XElement> ThirdQuerry(double x)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         where customer.Element("orders").Elements("order").Any(x1 => Double.Parse(x1.Element("total").Value) > x)
                         select customer;
            return querry;
        }

        //public void FourthQuerry()
        //{
        //    allCustomers = xDoc.Element("customers").Elements("customer");
        //    var querry = from customer in allCustomers.Elements("orders")
        //                 orderby Convert.ToDateTime(customer.Element("order").Elements("orderdate").Single().Value)//Sum(x => Double.Parse(x.Element("total").Value))
        //                 select customer;

        //    using (StreamWriter sw = new StreamWriter(Resource1.Querry4, false, Encoding.Default))
        //    {
        //       // sw.WriteLine("orders more than: " + sumX);
        //        foreach (var someCustomer in querry)
        //        {
        //            sw.WriteLine(someCustomer.Element("name").Value + "date of first order: " + someCustomer.Element("orders").Element("order").Element("orderdate").Value);
        //        }
        //    }
        //}
    }
}