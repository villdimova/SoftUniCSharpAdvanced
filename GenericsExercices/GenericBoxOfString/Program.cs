using System;

namespace GenericBoxOfString
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string currentItem = Console.ReadLine();
                box.Add(currentItem);
                
            }

            Console.WriteLine(box.ToString());
        }
    }
}
