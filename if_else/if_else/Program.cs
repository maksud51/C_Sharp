using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //odd or even
            int number = 16;
            if(number %2 == 0)
            {
                Console.WriteLine("Even");
            }

            else
            {
                Console.WriteLine("Odd");
            }

            //conditional operator
            var output = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(output);

            // switch statment
            var season = Season.spring;
            switch (season)
            {
                case Season.Summer:
                    Console.WriteLine("Summer");
                    break;
                case Season.Rainy:
                    Console.WriteLine("Rainy");
                    break;
                case Season.spring:
                    Console.WriteLine("Spring");
                    break;
                default:
                    Console.WriteLine("It might be some other season");
                    break;
            }

            //if else if
            int age = 20;

            if(age <= 17)
            {
                Console.WriteLine("kid");
            }

            else if (age >= 18 && age <= 50)
            {
                Console.WriteLine("Yong");
            }

            else
            {
                Console.WriteLine("old");
            }

        }
    }
}
