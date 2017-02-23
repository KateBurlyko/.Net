using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace CollectionTask
{
    class WorkWithLinkedList
    {
        public void InitLinkedList(LinkedList<string> linkeList, int quantityElements)
        {

            for (int j = 0; j < Settings1.Default.quantityElements; j++)
            {
                linkeList.AddFirst(Settings1.Default.contentElement);
            }
        }

        public void AddFirstElements(LinkedList<string> linkeList, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {
                linkeList.AddFirst("Kate");
            }
        }

        public void AddLastElements(LinkedList<string> linkeList, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {
                linkeList.AddLast("KateEnd");
            }
        }

        public void ReadFirstElements(LinkedList<string> linkeList, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {
                linkeList.Find("kate");
            }
        }

        public void ReadLastElements(LinkedList<string> linkeList, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {
                linkeList.Find("KateEnd");
            }
        }

        public void RemoveFirstElements(LinkedList<string> linkeList, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {

                linkeList.Remove("kate");
            }
        }

        public void RemoveLastElements(LinkedList<string> linkeList, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {

                linkeList.Remove("KateEnd");
            }
        }

        //StringBuilder stringBuilder = new StringBuilder("LinkedList: \n");
        //stringBuilder.Append("insert at the beginning: " + addBegin.ElapsedMilliseconds.ToString() + " ms, ");
        //stringBuilder.Append("\ninsert at the end: " + addEnd.ElapsedMilliseconds.ToString() + " ms, ");
        //stringBuilder.Append("\nread at the beginning: " + readBegin.ElapsedMilliseconds.ToString() + " ms, ");
        //stringBuilder.Append("\nread at the end: " + readEnd.ElapsedMilliseconds.ToString() + " ms, ");
        //stringBuilder.Append("\nremove at the beginning: " + removeBegin.ElapsedMilliseconds.ToString() + " ms, ");
        //stringBuilder.Append("\nremove at the end: " + removeEnd.ElapsedMilliseconds.ToString() + " ms");

        //string result = stringBuilder.ToString();
        //return result;
    }
}

