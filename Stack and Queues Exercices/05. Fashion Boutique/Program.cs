using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stackClothes = new Stack<int>(clothes);
            var rack = new Stack<int>();
            var clothesCount = stackClothes.Count();
            int rackCapacity = int.Parse(Console.ReadLine());
            int numRacks = 1;
            int rackClothesCount = 0;

            for (int i = 0; i < clothesCount; i++)
            {
                int currSum = rack.Sum();
                if (currSum + stackClothes.Peek() > rackCapacity)
                {
                    for (int j = 0; j < rackClothesCount; j++)
                    {
                        rack.Pop();
                    }
                    numRacks++;
                    rackClothesCount = 0;
                }


                rack.Push(stackClothes.Peek());
                stackClothes.Pop();
                rackClothesCount++;

            }

            Console.WriteLine(numRacks);
        }
    }
}
