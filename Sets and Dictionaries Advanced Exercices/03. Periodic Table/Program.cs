using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var compounds = Console.ReadLine().Split();

                for (int j = 0; j < compounds.Length; j++)
                {
                    uniqueElements.Add(compounds[j]);
                }
            }

            Console.WriteLine(String.Join(" ",uniqueElements));
        }
    }
}
