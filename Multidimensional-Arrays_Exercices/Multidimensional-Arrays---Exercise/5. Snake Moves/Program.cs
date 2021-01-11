using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string snake = Console.ReadLine();
            var queue = new Queue<string>();
            var queueLength = rows * cols;
            var numFullStrings = queueLength / snake.Length;
            var restStringLength = queueLength % snake.Length;
            var substringRest = snake.Substring(0, restStringLength).ToString();
            StringBuilder sb = new StringBuilder();
            string fullString = String.Empty;
            var matrix = new char[rows, cols];

            for (int i = 0; i < numFullStrings; i++)
            {
                fullString = sb.Append(snake).ToString();

            }

            fullString = sb.Append(substringRest).ToString();

           

            int num = fullString.Length / cols;
            

            for (int i = 0; i < num; i++)
            {
                string substring = String.Empty;
                substring = fullString.Substring(0, cols).ToString();
                queue.Enqueue(substring);
                fullString = fullString.Remove(0, cols).ToString();
            }

           

            for (int row = 0; row < rows; row++)
            {
                string currentRow = String.Empty;
                string reversedCurrentRow = String.Empty;
                char[] currentRowArray = new char[cols];

                if (row%2==0)
                {
                    currentRow = queue.Peek();
                    queue.Dequeue();
                    currentRowArray = currentRow.ToCharArray();

                }

                else
                {
                    currentRow = queue.Peek();
                    queue.Dequeue();
                    reversedCurrentRow = Reverse(currentRow);
                    currentRowArray = reversedCurrentRow.ToCharArray();
                }

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRowArray[col];
                }
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
           
        }

        public static string Reverse(string currentRow)
        {
            char[] charArray = currentRow.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
