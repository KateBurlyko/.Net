using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CollectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ListTime lt = new ListTime();
            WorkWithLinkedList ll = new WorkWithLinkedList();
            Queue q = new Queue();
            Stack s = new Stack();
            SortedSet ss = new SortedSet();
            SortedDictionary sd = new SortedDictionary();
            WorkWithDictionary d = new WorkWithDictionary();
             string path = @"C:\Users\Katsiaryna_Burlyka\Desktop\qwert.txt";
            //string path = @"C:\Users\Janek\Desktop\qwert.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string[] data = new string[7];
            data[0] = lt.list();
            data[1] = ll.linkedList();
            data[2] = q.queue();
            data[3] = s.stack();
            data[4] = ss.sortSet();
            data[5] = sd.sortDictionary();
            data[6] = d.WorkWithElementsDictionary();


            // This text is added only once to the file.
            if (!File.Exists(path))
            {

                File.WriteAllLines(path, data, Encoding.UTF8);
            }

            // Open the file to read from.
            //string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            //foreach (string s in readText)
            //{
            //    Console.WriteLine(s);
            //}

        }
    }
}
