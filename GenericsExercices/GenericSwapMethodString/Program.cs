using System;
using System.Linq;

namespace GenericSwapMethodString
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> boxCollection = new Box<string>();


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
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
