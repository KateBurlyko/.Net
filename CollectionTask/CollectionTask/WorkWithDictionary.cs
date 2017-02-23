using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace CollectionTask
{
    class WorkWithDictionary
    {

        public void InitDictionary(Dictionary<string, string> dictionary)
        {
            for (int j = 0; j < Settings1.Default.quantityElements; j++)
            {
                string finalValue = Settings1.Default.contentElement + j;
                string key = "key";
                string finalKey = key + j;
                dictionary.Add(finalKey, finalValue);

            }
        }
        public void AddElements(Dictionary<string, string> dictionary, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {
                string finalValue = "kate" + j;
                string finalKey = "Eds" + j;
                dictionary.Add(finalKey, finalValue);
            }
        }
        public void ReadElements(Dictionary<string, string> dictionary, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {

                string[] val = new string[quantityElements];
                val[j] = dictionary["Eds" + j];
            }
        }

        public void RemoveElements(Dictionary<string, string> dictionary, int quantityElements)
        {
            for (int j = 0; j < quantityElements; j++)
            {

                dictionary.Remove("kate" + j);
            }
        }

        //StringBuilder stringBuilder = new StringBuilder("Dictionary: \n");
        //stringBuilder.Append("insert at the beginning: " + addEnd.ElapsedMilliseconds.ToString() + " ms, ");
        //        stringBuilder.Append("\nread at the beginning: " + readBegin.ElapsedMilliseconds.ToString() + " ms, ");
        //        stringBuilder.Append("\nremove at the beginning: " + removeBegin.ElapsedMilliseconds.ToString() + " ms, ");
        //        string result = stringBuilder.ToString();

        //        return result;
    }
}
