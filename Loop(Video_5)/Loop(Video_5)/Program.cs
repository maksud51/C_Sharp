using System;

namespace Loop_Video_5_
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //for Loop
            int sum = 0;
/*            for (int i = 0; i < 11; i++)
            {
                sum = sum + i;
                
            }

             Console.WriteLine(sum);
            */

            //While Loop
            int j = 0;
            /*            while(true)
                        {
                            if(j > 10 )
                            {
                                break;
                            }
                            Console.WriteLine(j);
                            j++;

                        }*/

            while (j < 20)
            {
                j++;

                if (j % 5 == 0)
                {         
                    continue;

                }
                
                Console.WriteLine(j);
                
            }

            // do while
            int k=0;
            do
            {
              k++;

            } while (k > 5);
            Console.WriteLine(k);
        }
    }
}
