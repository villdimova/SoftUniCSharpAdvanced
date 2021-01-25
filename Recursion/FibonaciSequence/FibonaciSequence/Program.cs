using System;

namespace FibonaciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fibunacci(n));
        }

        public static long Fibunacci(long n)
        {
            if (n<=1)
            {
                return 1;
            }
            return Fibunacci(n - 1) + Fibunacci(n - 2);
        }
    }
}
