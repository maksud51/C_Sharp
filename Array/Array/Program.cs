using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Volbo", "Ford" };
            cars[0] = "Toyta";
            Console.WriteLine(cars[0]);
            

            int[] numbers = { 2, 3, 4, 5 };
            Console.WriteLine(numbers[2]);
            Console.ReadKey();

        }
    }
}
