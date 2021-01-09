using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                var action = command[0];

                if (action == "1")
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (action == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }

                }
                else if (action == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (action == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));

        }
    }
}

