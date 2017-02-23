using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTask
{
    class Queue
    {
        public string queue()
        {
            Queue<string> que = new Queue<string>();
            string[] data = new string[7];

            for (int j = 0; j < 20000000; j++)
            {
                que.Enqueue("welcom to the hell!");
            }

            Stopwatch addEnd = new Stopwatch();
            addEnd.Stop();
            //add in end
            que.Enqueue("kate");
            addEnd.Stop();

            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            que.Peek();
            readBegin.Stop();

            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start(); //remove first line
            que.Dequeue();
            removeBegin.Stop();

            StringBuilder stringBuilder = new StringBuilder("Queue: \n");
            stringBuilder.Append("insert at the beginning: " + addEnd.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nread at the beginning: " + readBegin.ElapsedMilliseconds.ToString() + " ms, ");
            stringBuilder.Append("\nremove at the beginning: " + removeBegin.ElapsedMilliseconds.ToString() + " ms, ");
            string result = stringBuilder.ToString();

            return result;

        }
    }
}
