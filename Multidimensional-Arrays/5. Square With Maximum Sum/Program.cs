using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = ParseArrayFromConsole();

            int rowLength = dimensions[0];
            int colLength = dimensions[1];
            int maxSum = int.MinValue;
            var maxSumMatrix = new int[2, 2];


            int[,] matrix = new int[rowLength, colLength];

            for (int row = 0; row < rowLength; row++)
            {
                int[] currentRow = ParseArrayFromConsole();

                for (int col = 0; col < colLength; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            List<int> sums = new List<int>();
            

            for (int row = 0; row < rowLength-1; row++)
            {


                for (int col = 0; col < colLength - 1; col++)
                {
                    int sum = matrix[row, col]
                        + matrix[(row + 1), col]
                        + matrix[row, (col + 1)]
                        +matrix[(row+1),(col+1)];

                    if (maxSum<sum)
                    {
                        maxSum = sum;

                        maxSumMatrix[0, 0] = matrix[row, col];
                        maxSumMatrix[0, 1] = matrix[row, col + 1];
                        maxSumMatrix[1, 0] = matrix[row+1, col];
                        maxSumMatrix[1, 1] = matrix[row + 1, col+1];

                    }

                    else if (maxSum==sum)
                    {
                        continue;
                    }
                   
                }

               
            }
            for (int maxSumRow = 0; maxSumRow < maxSumMatrix.GetLength(0); maxSumRow++)
            {
                for (int maxSumCol = 0; maxSumCol < maxSumMatrix.GetLength(1); maxSumCol++)
                {
                    Console.Write(maxSumMatrix[maxSumRow, maxSumCol] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);

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
