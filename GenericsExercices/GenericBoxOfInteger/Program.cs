using System;

namespace GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int currentItem = int.Parse(Console.ReadLine());
                box.Add(currentItem);

            }

            Console.WriteLine(box.ToString());
        }
    }
}
