﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            string[] input = Console.ReadLine().Split(" ").ToArray();

            Stack<string> stack = new Stack<string>(input);

            while (true)
            {
                if (stack.Count == 1)
                {
                    break;
                }

                int firstNum = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                int result = 0;

                    switch (sign)

                    {
                        case "+":
                            result = firstNum + secondNum;
                            
                            break;

                        case "-":
                            result = firstNum - secondNum;
                            
                            break;

                    }

                stack.Push(result.ToString());


            }

            Console.WriteLine(stack.Peek());
        }
    }
}
