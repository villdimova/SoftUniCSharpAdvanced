using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = ParseArrayFromConsole();

            int rowLength = dimensions[0];
            int colLength = dimensions[1];

            int[,] matrix = new int[rowLength, colLength];

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            for (int row = 0; row < rowLength; row++)
            {
                int[] currentRow = ParseArrayFromConsole();

                for (int col = 0; col < colLength; col++)
                {
                    matrix[row,col] = currentRow[col];
                }
            }

            long sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }

        static int[] ParseArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
