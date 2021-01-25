using System;

namespace Generating0_1Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            int[] vector = new int[size];
            Gen01(0, vector);
        }

        static void Gen01(int index, int[] vector)
        {
            if (index==vector.Length)
            {
                Print(vector);
            }
            else
            {
                vector[index] = 0;
                Gen01(index + 1, vector);

                vector[index] = 1;
                Gen01(index + 1, vector);
            }
        }

        private static void Print(int[] vector)
        {
            Console.WriteLine(String.Join("",vector));
        }
    }
}
