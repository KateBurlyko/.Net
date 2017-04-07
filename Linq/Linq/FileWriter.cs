using System.IO;
using System.Text;

namespace Linq
{
    class FileWriter
    {
        Querries querries = new Querries();
        public void FistQuerry(double sumX)
        {
            using (StreamWriter sw = new StreamWriter(Resource1.Querry1, false, Encoding.Default))
            {
                sw.WriteLine("the sum of all orders more than: " + sumX);
                foreach (var someCustomer in querries.FirstQuerry(sumX))
                {
                    sw.WriteLine(someCustomer.Element("name").Value);
                }
            }
        }
        public void SecondQuerry()
        {
            using (StreamWriter sw = new StreamWriter(Resource1.Querry2, false, Encoding.Default))
            {
                foreach (var someCustomer in querries.SecondQuerry())
                {
                    sw.WriteLine(someCustomer.Element("country").Value + " " + someCustomer.Element("name").Value);
                }
            }
        }
        public void ThirdQuerry(double x)
        {
            using (StreamWriter sw = new StreamWriter(Resource1.Querry3, false, Encoding.Default))
            {
                sw.WriteLine("any order more than: " + x);
                foreach (var someCustomer in querries.ThirdQuerry(x))
                {
                    sw.WriteLine(someCustomer.Element("name").Value);
                }
            }
        }
    }
}