using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().ToArray();
            int elementsToPush = int.Parse(command[0]);
            int elementsToPop = int.Parse(command[1]);
            int wantedElement = int.Parse(command[2]);

            var elements = Console.ReadLine().Split().ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(int.Parse(elements[i]));
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

            }

            var result = stack.Any(n => n == wantedElement);

            List<int> nums = new List<int>(stack);
            int minNum = 0;
            if (nums.Count > 0)
            {
                minNum = nums.Min();
            }


            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (result == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(minNum);
                }
            }
        }
    }
}
