using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
 
                switch(input[i])
                {
                    case '(':

                        stack.Push(i);
                        break;

                    case ')':
                        Console.WriteLine(input.Substring(stack.Peek(),i-stack.Peek()+1));
                        stack.Pop();
                        break;
                }

                    
            }
        }
    }
}
