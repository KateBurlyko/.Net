using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public static class Sqrt
    {
        public static void CountSqrt(List<BigInteger> numbers)
        {
          //  StringBuilder stringBuilder = new StringBuilder("\nsqrt ");
            foreach (BigInteger numb in numbers)
            {
                if (numb == 0)
                { }
                BigInteger summ = 0;
                BigInteger n1 = numb;

                while (n1 > 0)
                {
                    Coun:
                    if (n1 % 10 == 2)
                    {

                        Console.WriteLine("sqrt "+numb + " = " + SqRtN(numb));
                        break;
                    }
                    else if(n1>0)
                    {
                        n1 = n1 / 10;
                        goto Coun;
                       
                    }
                }
            }
            Console.Read();
        }
        public static BigInteger SqRtN(this BigInteger N)
        {
            /*++
             *  Using Newton Raphson method we calculate the
             *  square root (N/g + g)/2
             */
            BigInteger rootN = N;
            int bitLength = 1; // There is a bug in finding bit length hence we start with 1 not 0
            while (rootN / 2 != 0)
            {
                rootN /= 2;
                bitLength++;
            }
            bitLength = (bitLength + 1) / 2;
            rootN = N >> bitLength;

            BigInteger lastRoot = BigInteger.Zero;
           
            do
            {
                lastRoot = rootN;
                rootN = (BigInteger.Divide(N, rootN) + rootN) >> 1;
            }
            while (!((rootN ^ lastRoot).ToString() == "0"));
            return rootN;
        } // SqRtN
    }
}
