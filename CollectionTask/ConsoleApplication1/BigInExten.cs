using System;
using System.Numerics;

namespace ConsoleApplication1
{
    public static class BigInExten
    {
        /// <summary>
        /// get number and define 
        /// </summary>
        /// <param name="n"></param>
        /// <returns> number primary or not</returns>
        public static bool CheckingPrimeNumber(this BigInteger n)

        {
            BigInteger q = n;
            if (n == 1)
            {
                return false;
            }
            else if (n % 2 != 0)
            {
                for (int j = 3; j <= n / 2; j = j + 2)
                {
                    if (n % j == 0)
                    {
                        Console.WriteLine(q + " not prime");
                        return false;
                    }

                }
            }
            else
            {
                for (int i = 2; i <= n / 2; ++i)
                {


                    Console.WriteLine(q + " del on " + i);
                    if (n % i == 0)
                    {
                        Console.WriteLine(q + " not prime");
                        return false;
                    }
                }
            }
            Console.WriteLine(q + " prime");
            return true;
        }
    }
}

