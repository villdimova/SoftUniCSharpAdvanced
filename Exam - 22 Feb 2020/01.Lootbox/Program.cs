using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var firstBox = new Queue<int>(inputOne);

            var inputTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var secondBox = new Stack<int>(inputTwo);
            List<int> claimedItems = new List<int>();

            while(true)
            {
                if (firstBox.Count==0||secondBox.Count==0)
                {
                    if (firstBox.Count==0)
                    {
                        Console.WriteLine("First lootbox is empty");
                    }
                    else
                    {
                        Console.WriteLine("Second lootbox is empty");
                    }
                    break;
                }
                else
                {
                    int sum = firstBox.Peek() + secondBox.Peek();
                    if (sum % 2 == 0)
                    {
                        claimedItems.Add(sum);
                        firstBox.Dequeue();
                        secondBox.Pop();
                    }
                    else
                    {
                        int movedElement = secondBox.Pop();
                        firstBox.Enqueue(movedElement);
                    }
                       
                }
               
            }

            if (claimedItems.Sum()>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
            }

        }
    }
}
