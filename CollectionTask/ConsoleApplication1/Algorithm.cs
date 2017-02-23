using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApplication1
{
    class Algorithm
    {
        public List<BigInteger> Sequence(List<BigInteger> numbers)
        {

            BigInteger j = 1;
            int size = 0;
           // numbers.Add(0);
            for (BigInteger i = 1; size < 50; i += j)
            {
                numbers.Add(i);
                j = i - j;
                size = numbers.Count;
            }
            foreach (BigInteger c in numbers)
            {
                Console.WriteLine("dfg " + c);
            }
                 Console.ReadKey();

            return numbers;
        }
    }
}