using System;

namespace OOP_Video_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.firstName = "MD";
            p1.middleName = "ALL";
            p1.lastName = "MAKSUD";

            string fullName = p1.GetName();
            Console.WriteLine(fullName);



        }
    }
}
