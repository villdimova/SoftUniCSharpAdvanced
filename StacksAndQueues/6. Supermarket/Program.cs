using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            var queue = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name=="End")
                {
                    break;
                }
                else if (name=="Paid")
                {
                    int currCount = queue.Count;

                    for (int i = 0; i < currCount; i++)
                    {
                        Console.WriteLine(queue.Peek());
                        queue.Dequeue();
                    }
                    
                }
                else
                {
                    queue.Enqueue(name);
                }
               
            }

            int count = queue.Count;
            Console.WriteLine($"{count} people remaining.");
        }
    }
}
