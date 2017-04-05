using System;

namespace Сalculator
{
    class Numbers
    {
        public double[] Getnumbers(string v)
        {
            string[] numbers = v.Trim(new char[] { '=', '*', '+', '/', '-' }).
                               Split(new char[] { '-', '+', '*', '/' });
            double[] arr = new double[numbers.Length];
            for (int i = 0; i<numbers.Length; i++)
            {
                arr[i] = Double.Parse(numbers[i]);
            }
            return arr;
        }
    }
    class Operations
    {
        public double Add(double a, double b)
        {
            return (a + b);
        }

        public double Minus(double a, double b)
        {
            return (a - b);
        }

        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Division(double a, double b)
        {
            return (a / b);
        }
    }
}