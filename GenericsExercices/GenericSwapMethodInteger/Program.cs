using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> boxCollection = new Box<int>();


            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                boxCollection.Add(input);

            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            boxCollection.Swap(firstIndex, secondIndex);

            Console.WriteLine(boxCollection.ToString());
        }
    }
}
