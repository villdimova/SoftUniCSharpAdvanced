using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = ParseArray();

            int rows = demensions[0];
            int cols = demensions[1];

            var matrix = new int[rows, cols];
            var maxSumMatrix = new int[3, 3];


            for (int row = 0; row < rows; row++)
            {
                int[] currenRow = ParseArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currenRow[col];
                }
            }


            int maxSum = int.MinValue;
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    int sum = matrix[i, j]
                         + matrix[i, j + 1]
                         + matrix[i, j + 2]
                         + matrix[i + 1, j]
                         + matrix[i + 1, j + 1]
                         + matrix[i + 1, j + 2]
                         + matrix[i + 2, j]
                         + matrix[i + 2, j + 1]
                         + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumMatrix[0, 0] = matrix[i, j];
                        maxSumMatrix[0, 1] = matrix[i, j + 1];
                        maxSumMatrix[0, 2] = matrix[i, j + 2];
                        maxSumMatrix[1, 0] = matrix[i + 1, j];
                        maxSumMatrix[1, 1] = matrix[i + 1, j + 1];
                        maxSumMatrix[1, 2] = matrix[i + 1, j + 2];
                        maxSumMatrix[2, 0] = matrix[i + 2, j];
                        maxSumMatrix[2, 1] = matrix[i + 2, j + 1];
                        maxSumMatrix[2, 2] = matrix[i + 2, j + 2];


                    }
                }


            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < maxSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxSumMatrix.GetLength(1); col++)
                {
                    Console.Write(maxSumMatrix[row,col]+" ");
                }

                Console.WriteLine();
            }

        }

        static int[] ParseArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
