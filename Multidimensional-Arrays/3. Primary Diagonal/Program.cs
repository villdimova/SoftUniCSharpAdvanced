﻿using System;
using System.Linq;

namespace _3._Primary_Diagonal
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

            int diagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
