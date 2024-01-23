using System;

namespace Value_RefType_OOP__Video_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.fName = "AL";
            p1.mName = "MAKSUD";
            p1.lName = "ALAM";

            Console.WriteLine(p1.GetFullName());

            Person p2 = new Person();
            p2.fName = "A";
            p2.mName = "B";
            p2.lName = "C";

            Console.WriteLine(p2.GetFullName());

            Person p3 = new Person();
            p3 = p1;
            p3.mName = "Rafi";
            Console.WriteLine(p3.GetFullName());


        }
    }
}
