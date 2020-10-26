using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputMales = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var males = new Stack<int>(inputMales);

            var inputfemales = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var females = new Queue<int>(inputfemales);
            var matchesCount = 0;
           

            while (true)
            {
                if (females.Count == 0 || males.Count == 0)
                {
                    break;
                }
                else
                {
                    int currentMale = males.Peek();
                    int currentFemale = females.Peek();
                    if (currentFemale % 25 == 0)
                    {
                        females.Dequeue();
                        if (females.Count>0)
                        {
                            females.Dequeue();
                        }
                        continue;
                    }
                    if (currentFemale <= 0)
                    {
                        females.Dequeue();
                        if (females.Count < 0)
                        {
                            break;
                        }
                        continue;
                    }

                    if (currentMale <= 0)
                    {
                        males.Pop();

                        if (males.Count < 0)
                        {
                            break;
                        }
                        continue;
                    }

                    if (currentMale % 25 == 0)
                    {
                        males.Pop();
                        if (males.Count > 0)
                        {
                            males.Pop();
                        }

                        continue;
                    }

                    if (currentMale == currentFemale)
                    {
                        matchesCount++;
                        males.Pop();
                        females.Dequeue();
                        continue;
                    }
                    else
                    {
                        females.Dequeue();
                        males.Pop();
                        males.Push(currentMale - 2);
                        continue;
                    }
                }
            }


            Console.WriteLine($"Matches: {matchesCount}");
            if (males.Count == 0)
            {
                Console.WriteLine($"Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {String.Join(", ", males)}");
            }

            if (females.Count == 0)
            {
                Console.WriteLine($"Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {String.Join(", ", females)}");
            }

        }
    }
}
