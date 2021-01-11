using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 

            int rows = demensions[0];
            int cols = demensions[1];

            var matrix = new string[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                string[] currenRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray(); ;

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currenRow[col];
                }
            }
            string temp = String.Empty;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                else
                {
                    var command = input.Split();
                    if (command[0] == "swap" && command.Length == 5)
                    {
                        int firstElementRow = int.Parse(command[1]);
                        int firstElementCol = int.Parse(command[2]);
                        int secondElementRow = int.Parse(command[3]);
                        int secondElementCol = int.Parse(command[4]);

                        if ((firstElementRow >= 0 && firstElementRow < rows)
                            && (firstElementCol >= 0 && firstElementCol < cols)
                            && (secondElementRow >= 0 && secondElementRow < rows)
                            && (secondElementCol >= 0 && secondElementCol < cols))
                        {
                            temp = matrix[firstElementRow, firstElementCol];
                            matrix[firstElementRow, firstElementCol] = matrix[secondElementRow, secondElementCol];
                            matrix[secondElementRow, secondElementCol] = temp;

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col] + " ");
                                }

                                Console.WriteLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }


                }

                

            }

            
        }

        
    }
}
