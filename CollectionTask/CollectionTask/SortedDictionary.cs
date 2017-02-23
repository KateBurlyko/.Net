using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CollectionTask
{
    class SortedDictionary
    {
        public string sortDictionary()
        {
            SortedDictionary<string, string> sortDictionary = new SortedDictionary<string, string>();
            string[] data = new string[7];

            for (int j = 0; j < 2000000; j++)
            {
                string value = "welcome to hell!";
                string finalValue = value + j;
                string key = "key";
                string finalKey = key + j;
                sortDictionary.Add(finalKey, finalValue);

            }

            Stopwatch addBegin = new Stopwatch();
            addBegin.Start();
            sortDictionary.Add("Eds", "kate");
            addBegin.Stop();

            Stopwatch addEnd = new Stopwatch();
            addEnd.Stop();
            sortDictionary.Add("zip", "kateEds");
            DateTime finishAddInEnd = new DateTime(DateTime.Now.Millisecond);
            addEnd.Stop();

            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            sortDictionary.Values.Last();
            readBegin.Stop();

            Stopwatch readEnd = new Stopwatch();
            readEnd.Start();
            sortDictionary.Values.First();
            readEnd.Stop();

            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start();
            sortDictionary.Remove("Eds");
            removeBegin.Stop();

            Stopwatch removeEnd = new Stopwatch();
            removeEnd.Start();
            sortDictionary.Remove("zip");
            removeEnd.Stop();

            StringBuilder stringBuilder = new StringBuilder("SortedDictionary: \n");
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
