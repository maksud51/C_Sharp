using Class.Math;
using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + firstName + " " + lastName);
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person male = new Person();
            male.firstName = "Maksud";
            male.lastName = "Alam";

            male.Introduce();
            int result = Calculator.Add(13, 17);
            Console.WriteLine("Add"+result);
            Console.ReadKey();




        }
    }
}
