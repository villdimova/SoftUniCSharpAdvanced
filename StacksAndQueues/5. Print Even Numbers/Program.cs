using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = Console.ReadLine().Split().ToList();
            var queue = new Queue<int>();
            var evenNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (int.Parse(numbers[i])%2==0)
                {
                    queue.Enqueue(int.Parse(numbers[i]));
                
                }
                else
                {
                    continue;
                }

            }

            int count = queue.Count;

            for (int j = 0; j < count; j++)
            {
                evenNums.Add(queue.Peek());
                queue.Dequeue();

            }

            Console.Write(String.Join(", ", evenNums));

        }
    }
}
