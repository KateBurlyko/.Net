using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    class Numbers
    {
        delegate string Operation(string[] numbers);
        Operation operation;
        public string getNumbers(string v)
        {
            if (v.Contains("-")) operation = Minus;
            if (v.Contains("+")) operation = Add;
            if (v.Contains("/")) operation = Division;
            if (v.Contains("*")) operation = Multiply;
            string[] numbers = v.Trim(new char[] { '=', '*', '+', '/', '-' }).
                               Split(new char[] { '-', '+', '*', '/' });
            return operation.Invoke(numbers);
        }

        private string Add(string[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += Double.Parse(numbers[i]);
            }
            return result.ToString();
        }

        private string Minus(string[] numbers)
        {
            double result = Double.Parse(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= Double.Parse(numbers[i]);
            }
            return result.ToString();
        }

        private string Multiply(string[] numbers)
        {
            double result = Double.Parse(numbers[0]); ;
            for (int i = 1; i < numbers.Length; i++)
            {
                result *= Double.Parse(numbers[i]);
            }
            return result.ToString();
        }

        private string Division(string[] numbers)
        {
            double result = Double.Parse(numbers[0]); ;
            for (int i = 1; i < numbers.Length; i++)
            {
                result /= Double.Parse(numbers[i]);
            }
            return result.ToString();
        }
    }
}