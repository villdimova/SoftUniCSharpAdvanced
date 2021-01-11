using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                firstDiagonal += matrix[i, i];
            }

            

            for (int i = 0; i < n; i++)
            {
                secondDiagonal += matrix[i, (n-1)-i];
            }

            int difference = Math.Abs(firstDiagonal - secondDiagonal);
            Console.WriteLine(difference);
        }
    }
}
