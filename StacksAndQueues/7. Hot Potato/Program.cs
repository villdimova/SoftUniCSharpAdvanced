using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();

            var queue = new Queue<string>(kids);

            int toss = int.Parse(Console.ReadLine());


            while (queue.Count>1)
            {
                
                for (int i = 1; i < toss; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                    
                }

                
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
