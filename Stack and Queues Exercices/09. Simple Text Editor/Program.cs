using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            var stack = new Stack<string>();
            stack.Push(sb.ToString());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                var action = command[0];

                if (action == "1")
                {
                    sb.Append(command[1]);
                    stack.Push(sb.ToString());
                }

                else if (action == "2")
                {
                    int count = int.Parse(command[1]);
                    sb.Remove(sb.Length - count, count);
                    stack.Push(sb.ToString());


                }
                else if (action == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                else if (action == "4")
                {
                    stack.Pop();
                    sb = new StringBuilder();
                    sb.Append(stack.Peek());
                }
            }
        }
    }
}

