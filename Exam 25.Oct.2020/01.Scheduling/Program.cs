using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var tasks = new Stack<int>(inputOne);

            var inputTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var threads = new Queue<int>(inputTwo);

            int dangerousTask = int.Parse(Console.ReadLine());
            int myThread = 0;

            while (true)
            {
                int currentThread = threads.Peek();
                int currentTaks = tasks.Peek();

                if (currentTaks==dangerousTask)
                {
                   
                        myThread = threads.Peek();
                        tasks.Pop();
                        Console.WriteLine($"Thread with value {currentThread} killed task {dangerousTask}");
                        break;
                }
                else
                {
                    if (currentThread >= currentTaks)
                    {
                        tasks.Pop();
                        threads.Dequeue();
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
            }
        }
    }
}
