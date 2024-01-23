using System;

namespace Method_video_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add1(4, 5);
            Console.WriteLine(result);
        }

        static int Add1(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
    }
}
