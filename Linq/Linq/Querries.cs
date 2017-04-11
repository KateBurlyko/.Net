using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq
{
    class Querries
    {
        public XDocument xDoc = XDocument.Load(Resource1.XmlPath);
        public IEnumerable<XElement> allCustomers;

        public IEnumerable FirstQuerry(double sumX)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         where customer.Element("orders").Elements("order").Sum(x => double.Parse(x.Element("total").Value)) > sumX
                         select customer.Element("name").Value;
            return querry;
        }

        public IEnumerable SecondQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         orderby customer.Element("country").Value
                         select $"{customer.Element("country").Value} {customer.Element("name").Value}";
            return querry;
        }

        public IEnumerable ThirdQuerry(double x)
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers
                         where customer.Element("orders").Elements("order").Any(x1 => double.Parse(x1.Element("total").Value) > x)
                         select customer.Element("name").Value;
            return querry;
        }

        public IEnumerable FourthQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers.Where(x => x.Descendants("order").Any())
                         let mounth = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                         let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                         select $"{customer.Element("name").Value} {mounth} {year}";
            return querry;
        }

        public IEnumerable FifthQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers.Where(x => x.Descendants("order").Any())
                         let mounth = DateTime.Parse(customer.Descendants("orderdate").First().Value).Month
                         let year = DateTime.Parse(customer.Descendants("orderdate").First().Value).Year
                         let sum = customer.Element("orders").Elements("order").Sum(x => double.Parse(x.Element("total").Value))
                         let name = customer.Element("name").Value
                         orderby year, mounth, sum, name descending
                         select new
                         {
                             Name = name,
                             Year = year,
                             Mounth = mounth,
                             Sum = sum
                         };
            return querry;
        }

        public IEnumerable SixthQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var querry = from customer in allCustomers.Where(e => (!e.Elements("region").Any()) ||
                                           e.Elements("postalcode").Any() && !e.Element("postalcode").Value.All(ch => char.IsDigit(ch) || ch == '-') ||
                                           !e.Element("phone").Value.Contains("(") && !e.Element("phone").Value.Contains(")"))
                         select customer.Element("name").Value;
            return querry;
        }
        public IEnumerable SeventhQuerry()
        {
            allCustomers = xDoc.Element("customers").Elements("customer");
            var groupByCity = from city in allCustomers
                       group city by city.Element("city").Value;
            var querry = from customer in groupByCity
                         let averagePrise = customer.Descendants("order").Average(x => double.Parse(x.Element("total").Value))
                         let quantityOrders = customer.Descendants("order").Count()
                         let quantityCustomers = customer.Count()
                         orderby customer.Elements("city").First().Value
                         select $"city: {customer.Elements("city").First().Value} -average price: {averagePrise} average quantity of orders: {quantityOrders / quantityCustomers}";
            return querry;
        }
    }
}