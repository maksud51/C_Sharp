using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Queue_Video_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack

            /*            Stack stack = new Stack();
                        stack.Push(121);
                        stack.Push("abc");
                        stack.Push(121.121);
                        stack.Push('c');
                        stack.Push(12.0);

                        foreach(var data in stack)
                        {
                            Console.WriteLine(data);
                        }

                        stack.Pop();*/

            Stack<int> stck = new Stack<int>();
            stck.Push(12);

            //Queue

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }

            queue.Dequeue();


        }
    }
}
