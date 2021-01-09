using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<char>();


            for (int i = 0; i < input.Length; i++)
            {
                char element = input[i];

                if (element == '(')
                {
                    stack.Push(element);
                }

                else if (element == '{')
                {
                    stack.Push(element);
                }
                else if (element == '[')
                {
                    stack.Push(element);
                }
                else if (element == ')')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }

                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
                else if (element == '}')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }

                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
                else if (element == ']')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }

                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }

                else if (element == ' ')
                {

                    Console.WriteLine("NO");
                    return;

                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }


        }
    }
}
