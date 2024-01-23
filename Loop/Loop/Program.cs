using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //while loop
            var x = 10;
            while (x <= 20)
            {
                Console.WriteLine(x);
                x++;
            }

            //do while
            var y = 30;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y <=60);

            //forEach

            int[] numbers = { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }


	}
    
}
