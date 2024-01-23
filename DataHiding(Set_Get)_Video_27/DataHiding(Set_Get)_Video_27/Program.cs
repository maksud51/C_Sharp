using System;

namespace DataHiding_Set_Get__Video_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            string fN = Console.ReadLine();
            p1.FirstName = fN;
            Console.WriteLine(p1.FirstName);
            Console.WriteLine(p1.GetFullName());
        }
    }
}
