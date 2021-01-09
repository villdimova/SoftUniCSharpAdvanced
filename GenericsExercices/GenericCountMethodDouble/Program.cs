using System;

namespace GenericCountMethodDouble
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double item = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Compare(item));
        }
    }
}
