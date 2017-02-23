using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace ConsoleApplication1
{
    class DelFive
    {
        public void CheckFive(List<BigInteger> numbers)
        {
            //Func<BigInteger, bool> GreaterThanTwo = i => (i%5==0);
            //List<BigInteger> list = numbers.GreaterThanTwo;

            foreach (BigInteger numb in numbers)
            {
                if (numb % 5 == 0)
                {
                    Console.WriteLine("some numbers divide into five");
                    break;
                }

            }
        }
    }
}   