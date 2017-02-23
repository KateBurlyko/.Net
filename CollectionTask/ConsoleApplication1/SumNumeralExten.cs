using System.Numerics;

namespace ConsoleApplication1
{
    public static class SumNumeralExten
    {
        public static bool CountNumeral(this BigInteger n)
        {
            BigInteger summ = 0;
            BigInteger n1 = n;
            while (n > 0)
            {
                summ = summ + (n % 10);
                n = n / 10;
            }


            if (summ !=0 && n1 % summ != 0) 
                return false;

            return true;
        }
    }
}
