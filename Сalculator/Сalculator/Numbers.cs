using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    class Numbers
    {
        public string getNumbers(string v)
        {
            char[] charsToTrim = { '=', '*', '+', '/', '-' };
            string[] numbers = v.Trim(charsToTrim).Split(new char[] { '+' });
            double[] number = new double[numbers.Length];
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += Double.Parse(numbers[i]);
            }
            return result.ToString();
        }
    }
}
