using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictonary_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary

            Dictionary<int, string> dicronary = new Dictionary<int, string>();
            dicronary.Add(1, "asbc");
            dicronary.Add(2, "asbc");

            //Surch
            string output;
            if (dicronary.TryGetValue(2, out output))
            {
                Console.WriteLine("Find Data"+output);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            foreach (var item in dicronary)
            {
                Console.WriteLine("Key="+item.Key +" Value=" +item.Value);
            }

            //HashTable

            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "agga");
            hashtable.Add(1, 1);
            hashtable.Add("a", "b");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }

            //surch
            if (hashtable.Contains("1");
            {
                Console.WriteLine("data found");
            }

            //upadte
            hashtable["1"] = "one";


        }
    }
}
