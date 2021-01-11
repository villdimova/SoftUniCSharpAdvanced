using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumCols = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumCols += matrix[row, col];
                }

                Console.WriteLine(sumCols);
            }

            
        }
    }
}
