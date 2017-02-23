using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace CollectionTask
{
    class ListTime
    {
        public string list()
        {
            List<string> list = new List<string>();

            for (int j = 0; j < 20000000; j++)
            {
                list.Add("welcom to the hell!");
            }

            Stopwatch addBegin = new Stopwatch();
            addBegin.Start();

            list.Insert(0, "kate");
            addBegin.Stop();

            Stopwatch addEnd = new Stopwatch();
            addEnd.Stop();
            list.Add("kateEnd");
            addEnd.Stop();

            int c = list.Count();

            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            string readElement = list[0];                   //Find(x => x.Contains("kate"));
            readBegin.Stop();

            Stopwatch readEnd = new Stopwatch();
            readEnd.Start();
            string reaEnd = list[c - 1];                       // Find(x => x.Contains("kateEnd"));
            readEnd.Stop();

            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start();
            list.RemoveAt(0);
            removeBegin.Stop();

            Stopwatch removeEnd = new Stopwatch();
            removeEnd.Start();
            list.RemoveAt(c - 2);
            removeEnd.Stop();



            StringBuilder stringBuilder = new StringBuilder("List: \n");
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
