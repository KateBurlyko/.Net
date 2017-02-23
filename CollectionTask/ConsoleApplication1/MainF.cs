using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApplication1
{
    class MainF
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = new List<BigInteger>();
            Algorithm al = new Algorithm();
            DelFive del = new DelFive();
            


            al.Sequence(numbers);
            del.CheckFive(numbers);
           // sq.CountSqrt(numbers);


            //define primary numbers
            int numberPrime = numbers.Count(s => s.CheckingPrimeNumber());
            Console.WriteLine("quantity of prime numbers = " + numberPrime);

            //count number on sum
            int numberDel = numbers.Count(s => s.CountNumeral());
            Console.WriteLine("quantity of numbers which divide on sum their numerals = " + numberDel);
            Console.ReadKey();


        }
    }
}