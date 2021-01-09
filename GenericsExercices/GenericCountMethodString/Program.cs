using System;

namespace GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string item = Console.ReadLine();
            Console.WriteLine(box.Compare(item));
        }
    }
}
