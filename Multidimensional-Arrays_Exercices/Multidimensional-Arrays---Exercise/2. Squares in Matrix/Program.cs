using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int equalsCount = 0;
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    char currElement = matrix[i, j];
                    if (currElement==matrix[i,j+1]
                        && currElement==matrix[i+1,j]
                        &&currElement==matrix[i+1,j+1])
                    {
                        equalsCount++;
                    }
                }
            }
            
                Console.WriteLine(equalsCount);
           
           


        }
    }
}
