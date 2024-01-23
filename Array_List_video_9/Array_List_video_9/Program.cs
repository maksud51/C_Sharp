using System;

namespace Array_List_video_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int size = Convert.ToInt32(Console.ReadLine());*/
            int[] number = new int[5];
/*          number[0] = 20;
            number[1] = 20;
            number[2] = 20;
            number[3] = 20;*/

            for(int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*            for (int i = 0; i < number.Length; i++ )
                        {
                            Console.WriteLine(number[i]);
                        }*/
            
            foreach (var data in number)
            {
                Console.WriteLine(data);
            }

            
        }
    }
}
