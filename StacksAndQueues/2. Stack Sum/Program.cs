using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split().ToList();
            
            var myStack = new Stack<int>();

            foreach (var item in inputLine)
            {
                myStack.Push(int.Parse(item));
            }

            var input = String.Empty;

            while ((input=Console.ReadLine().ToLower())!="end")
            {
                string[] command = input.Split().ToArray();
                
                if (input.Contains("add"))
                {
                    int numOne = int.Parse(command[1]);
                    int numTwo = int.Parse(command[2]);
                    myStack.Push(numOne);
                    myStack.Push(numTwo);
                }

                if (input.Contains("remove"))
                {
                    int num = int.Parse(command[1]);

                    if (myStack.Count>=num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            myStack.Pop();
                        }
                    }
                    else
                    {
                        continue;
                    }
                    
                    
                }

            }

            var finalNums= new List<int>(myStack).ToList();
            int sum = finalNums.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
