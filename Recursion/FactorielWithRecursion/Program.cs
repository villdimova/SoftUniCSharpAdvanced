using System;

namespace FactorielWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
           Console.WriteLine( Factorial(num));

        }

        static decimal Factorial(decimal num)
        {
            if (num==0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
