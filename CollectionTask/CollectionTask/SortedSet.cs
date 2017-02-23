using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CollectionTask
{
    class SortedSet
    {
        public string sortSet()
        {
            SortedSet<string> sorted = new SortedSet<string>();
            string[] data = new string[7];

            for (int j = 0; j < 20000000; j++)
            {
                sorted.Add("welcom to the hell!");
            }

            Stopwatch addBegin = new Stopwatch();
            addBegin.Start();
            sorted.Add("hedgehog");
            addBegin.Stop();

            Stopwatch addEnd = new Stopwatch();
            addEnd.Stop();
            sorted.Add("zero");
            addEnd.Stop();

            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            sorted.Max();
            readBegin.Stop();

            Stopwatch readEnd = new Stopwatch();
            readEnd.Start();
            sorted.Min();
            readEnd.Stop();

            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start();
            sorted.Remove("hedgehog");
            removeBegin.Stop();

            Stopwatch removeEnd = new Stopwatch();
            removeEnd.Start();
            sorted.Remove("zero");
            removeEnd.Stop();

            StringBuilder stringBuilder = new StringBuilder("SortedSet: \n");
            stringBuilder.Append("insert at the beginning: " + addBegin.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\ninsert at the end: " + addEnd.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nread at the beginning: " + readBegin.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nread at the end: " + readEnd.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nremove at the beginning: " + removeBegin.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nremove at the end: " + removeEnd.ElapsedMilliseconds.ToString() + " ms");



            string total = stringBuilder.ToString();
            return total;

        }
    }
}
