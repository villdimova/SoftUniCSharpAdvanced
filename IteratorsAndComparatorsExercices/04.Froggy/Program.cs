using System;
using System.Linq;

namespace _04.Froggy
{
   public class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToList();

            Lake lake = new Lake(stones);

            Console.WriteLine(String.Join(", ",lake));
                
        }
    }
}
