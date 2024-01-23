using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn = "maksud";
            string ln = "alam";

            string myFullName = string.Concat(fn, ln);
            Console.WriteLine(myFullName);

            Console.WriteLine(fn.IndexOf("s"));
            Console.WriteLine(fn[3]);
        }
    }
}
