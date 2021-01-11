using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();


                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            char element = char.Parse(Console.ReadLine());
            bool match = false;

            for (int row = 0; row < n; row++)
            {
                

                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col] == element)
                    {
                        Console.WriteLine($"({row}, {col})");
                        match = true;
                        return;
                    }
                   
                }
            }

            Console.WriteLine($"{element} does not occur in the matrix");
        }
    }
}
