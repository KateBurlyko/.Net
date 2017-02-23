using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using framework.LoginData;

namespace framework.Parser
{
    class ParsingLoginPassword
    {
        public List<LoginDatas> GetLogin()
        {
            string[] cars = File.ReadAllLines(@"C:\Users\Katsiaryna_Burlyka\Desktop\login.csv");
            List<LoginDatas> list = new List<LoginDatas>();
            for (int i = 0; i < cars.Length; i++)
            {
                string[] split = cars[i].Split(new char[] { ',' });
                
                list.Add(new LoginDatas(split[0], split[1], split[2]));

            }
            return list;
        }
    }
}
