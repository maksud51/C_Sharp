using System;

namespace Prectice
{
    class program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 1st Number");
            int number = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int add = number + number2;
            int sub = number - number2;
            int mul = number * number2;
            int div = number / number2;

            Console.WriteLine("Addition = " + number + "\n" + "Subtraction = " +sub + "\n" + "Multiplicationb = " +mul + "\n" +"Divition = " +div );
            Console.ReadKey();
        }

    }
}
