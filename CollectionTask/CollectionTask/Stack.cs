using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CollectionTask
{
    class Stack
    {
        public string stack()
        {
            Stack<string> stak = new Stack<string>();
            string[] data = new string[7];

            for (int j = 0; j < 20000000; j++)
            {
                stak.Push("welcom to the hell!");
            }

            Stopwatch addEnd = new Stopwatch();
            addEnd.Stop(); //add in end
            stak.Push("kate");
            addEnd.Stop();

            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            stak.Peek();
            readBegin.Stop();

            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start(); //remove first line
            stak.Pop();
            removeBegin.Stop();

            StringBuilder stringBuilder = new StringBuilder("Stack: \n");
            stringBuilder.Append("insert at the beginning: " + addEnd.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nread at the beginning: " + readBegin.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nremove at the beginning: " + removeBegin.ElapsedMilliseconds.ToString() + " ms, ");




            string total = stringBuilder.ToString();
            return total;
        }
    }
}
