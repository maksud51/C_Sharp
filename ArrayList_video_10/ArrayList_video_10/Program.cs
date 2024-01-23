using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_video_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArryList
            ArrayList arr = new ArrayList();
            arr.Add(14);
            arr.Add("assj");
            arr.Add(14.23);
            arr.Add(141);
/*            arr.Remove(14);
            arr.RemoveAt(0);
            arr.RemoveRange(2, 4);*/
            foreach(var data in arr)
            {
                Console.WriteLine(arr);
            }

            //List
            List<string> name = new List<string>();
            name.Add("amam");
            name.Add("amam");
            name.Add("amam");
            name.Add("amam");

            
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

        }
    }
}
