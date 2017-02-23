using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTask
{
    class GettingTimes
    {
        WorkWithDictionary wwd = new WorkWithDictionary();
        WorkWithLinkedList wwll = new WorkWithLinkedList();

        public string GetTimeAddFirstElements(LinkedList<string> linkeList, int quantityElements)
        {
            Stopwatch addBegin = new Stopwatch();
            addBegin.Start();
            wwll.AddFirstElements(linkeList, quantityElements);
            addBegin.Stop();
            TimeSpan resultTime = addBegin.Elapsed;
            return resultTime.Milliseconds.ToString();
        }

        public string GetTimeAddLastElements(LinkedList<string> linkeList, int quantityElements)
        {
            Stopwatch addEnd = new Stopwatch();
            addEnd.Stop();
            wwll.AddLastElements(linkeList, quantityElements);
            addEnd.Stop();
            TimeSpan resultTime = addEnd.Elapsed;
            return resultTime.Milliseconds.ToString();
        }

        public string GetTimeReadFirstElements(LinkedList<string> linkeList, int quantityElements)
        {
            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            wwll.ReadFirstElements(linkeList, quantityElements);
            readBegin.Stop();
            TimeSpan resultTime = readBegin.Elapsed;
            return resultTime.Milliseconds.ToString();
        }

        public string GetTimeReadLastElements(LinkedList<string> linkeList, int quantityElements)
        {
            Stopwatch readEnd = new Stopwatch();
            readEnd.Start();
            wwll.ReadFirstElements(linkeList, quantityElements);
            readEnd.Stop();
            TimeSpan resultTime = readEnd.Elapsed;
            return resultTime.Milliseconds.ToString();
        }

        public string GetTimeRemoveFirstElements(LinkedList<string> linkeList, int quantityElements)
        {
            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start();
            wwll.RemoveFirstElements(linkeList, quantityElements);
            removeBegin.Stop();
            TimeSpan resultTime = removeBegin.Elapsed;
            return resultTime.Milliseconds.ToString();
        }

        public string GetTimeRemoveLastElements(LinkedList<string> linkeList, int quantityElements)
        {
            Stopwatch removeEnd = new Stopwatch();
            removeEnd.Start();
            wwll.RemoveFirstElements(linkeList, quantityElements);
            removeEnd.Stop();
            TimeSpan resultTime = removeEnd.Elapsed;
            return resultTime.Milliseconds.ToString();
        }

        public string GetTimeAddElements(Dictionary<string, string> dictionary, int quantityElements)
        {
            Stopwatch addEnd = new Stopwatch();
            addEnd.Start();
            wwd.AddElements(dictionary, quantityElements);
            addEnd.Stop();
            TimeSpan resultTime = addEnd.Elapsed;
            return resultTime.Milliseconds.ToString();

        }
        public string GetTimeReadElements(Dictionary<string, string> dictionary, int quantityelements)
        {
            Stopwatch readBegin = new Stopwatch();
            readBegin.Start();
            wwd.ReadElements(dictionary, quantityelements);
            readBegin.Stop();
            TimeSpan resultTime = readBegin.Elapsed;
            return resultTime.Milliseconds.ToString();
        }


        public string GetTimeRemoveElements(Dictionary<string, string> dictionary, int quantityElements)
        {
            Stopwatch removeBegin = new Stopwatch();
            removeBegin.Start();
            wwd.ReadElements(dictionary, quantityElements);
            removeBegin.Stop();
            TimeSpan resultTime = removeBegin.Elapsed;
            return resultTime.Milliseconds.ToString();
        }
    }
}
