using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().ToArray();
            int elementsToAdd = int.Parse(command[0]);
            int elementsToRemove = int.Parse(command[1]);
            int wantedElement = int.Parse(command[2]);

            var elements = Console.ReadLine().Split().ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < elementsToAdd; i++)
            {
                queue.Enqueue(int.Parse(elements[i]));

            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }

            }

            if (queue.Contains(wantedElement))
            {
                Console.WriteLine("true");
            }

            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }

                else
                {
                    Console.WriteLine("0");
                }
            }




        }


    }
}
