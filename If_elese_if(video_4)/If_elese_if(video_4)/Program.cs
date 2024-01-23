using System;

namespace If_elese_if_video_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Score:");
            string score = Console.ReadLine();
            int _score = Convert.ToInt32(score);
            //int _score = int.Parse(score);
            //int _score = int.Parse(Console.ReadLine());

            string result = string.Empty;

            if(_score > 100 || _score < 0)
            {
                result = "Score should be 0 t0 100";
            }

           else if(_score >= 50)
            {
                result = "You are Pass"; //Console.WriteLine("You are Pass");
            }


            else
            {
                result = "You are Fail";  //Console.WriteLine("You are Fail");
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
