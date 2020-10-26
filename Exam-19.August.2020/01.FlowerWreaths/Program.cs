using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLilies = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var lilies = new Stack<int>(inputLilies);

            var inputRoses = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var roses = new Queue<int>(inputRoses);
            int wreathCount = 0;
            int storedSum = 0;

            while (true)
            {
                if (lilies.Count == 0 || roses.Count == 0)
                {
                    break;
                }
                else
                {
                    int sum = lilies.Peek() + roses.Peek();

                    if (sum == 15)
                    {
                        wreathCount++;
                        roses.Dequeue();
                        lilies.Pop();

                    }
                    else if (sum < 15)
                    {
                        storedSum += sum;
                        roses.Dequeue();
                        lilies.Pop();
                    }
                    else if (sum > 15)
                    {
                        int currentSum = sum;
                        while (true)
                        {
                            int currentLily = lilies.Peek();
                            currentLily -= 2;
                            lilies.Pop();
                            lilies.Push(currentLily);
                            currentSum = lilies.Peek() + roses.Peek();
                            if (currentSum == 15)
                            {
                                wreathCount++;
                                roses.Dequeue();
                                lilies.Pop();
                                break;
                            }
                            else if (currentSum < 15)
                            {
                                storedSum += currentSum;
                                roses.Dequeue();
                                lilies.Pop();
                                break;
                            }
                        }
                    }
                }

            }

            if (storedSum >= 15)
            {
                int additionalWreath = storedSum / 15;
                wreathCount += additionalWreath;

            }

            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }

        }
    }
}
