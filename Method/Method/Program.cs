using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            int myAge = age(2020, 1999);
            if (myAge >= 18)
            {
                Console.WriteLine("Adult " + myAge);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine(" Not Adult " + myAge);
                Console.ReadKey();
            }

        }

        public static int age(int currentYear, int dateOfBirth)
        {
            return (currentYear - dateOfBirth);

        }
    }
}