using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> cupsQueue = new Queue<int>(cups);

            int[] bottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> bottlesStack = new Stack<int>(bottles);
            int wastedLiters = 0;

            while (true)
            {
                if (bottlesStack.Count == 0)
                {
                    if (cupsQueue.Count > 0)
                    {
                        Console.WriteLine($"Cups: {String.Join(" ", cupsQueue)}");
                    }

                    break;
                }

                if (cupsQueue.Count == 0)
                {
                    if (bottlesStack.Count > 0)
                    {
                        Console.WriteLine($"Bottles: {String.Join(" ", bottlesStack)}");
                    }

                    break;
                }

                while (true)

                {
                    if (cupsQueue.Count == 0 || bottlesStack.Count == 0)
                    {
                        break;
                    }
                    int cupCapacity = cupsQueue.Peek();
                    cupCapacity -= bottlesStack.Pop();

                    if (cupCapacity <= 0)
                    {
                        wastedLiters += Math.Abs(cupCapacity);
                        cupsQueue.Dequeue();

                    }

                    else
                    {
                        while (true)
                        {
                            cupCapacity -= bottlesStack.Pop();
                            if (cupCapacity <= 0)
                            {
                                wastedLiters += Math.Abs(cupCapacity);
                                cupsQueue.Dequeue();
                                break;
                            }
                        }
                    }


                }
            }

            Console.WriteLine($"Wasted litters of water: {wastedLiters}");


        }


    }
}
