using framework.Login;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] login = File.ReadAllLines(@"C:\Users\Janek\Desktop\login.csv");
            List<LoginData> list = new List<LoginData>();
            for (int i = 1; i < login.Length; i++)
            {
                string[] split = login[i].Split(new char[] { ',' });

                list.Add(new LoginData(split[0], split[1], split[2]));

            }

            foreach (LoginData lg in list)
            {
                Console.WriteLine(lg.Expected);
                Console.WriteLine(lg.Login);
                Console.WriteLine(lg.Password);
            }
            Console.ReadKey();
        }
    }
}