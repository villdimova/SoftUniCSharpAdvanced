using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var setsLength = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstSetLength = setsLength[0];
            var secondSetLength = setsLength[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                var element = int.Parse(Console.ReadLine());
                firstSet.Add(element);
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                var element = int.Parse(Console.ReadLine());
                secondSet.Add(element);
            }

            var uniqueElements = new HashSet<int>();

            foreach (var firstElement in firstSet)
            {
                foreach (var secondElement in secondSet)
                {
                    if (firstElement==secondElement)
                    {
                        uniqueElements.Add(firstElement);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", uniqueElements));
            
        }
    }
}
