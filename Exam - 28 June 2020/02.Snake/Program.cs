using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _02.Snake
{
    public class Snake
    {
        public Snake(int snakeRow, int snakeCol)
        {
            this.SnakeRow = snakeRow;
            this.SnakeCol = snakeCol;
            this.FoodQuantiny = 0;
        }

        public int SnakeRow { get; set; }
        public int SnakeCol { get; set; }
        public int FoodQuantiny { get; set; }
    }
    public class Burrow
    {
        public Burrow(int burrowRow, int burrowcol)
        {
            this.BurrowRow = burrowRow;
            this.BurrowCol = burrowcol;
        }
        public int BurrowRow { get; set; }
        public int BurrowCol { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = GetMatrix(n);
            //PrintMatrix(matrix);

            Snake snake = GetSnake(matrix);
            matrix[snake.SnakeRow, snake.SnakeCol] = '.';
            List<Burrow> burrows = GetBurrows(matrix);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (snake.SnakeRow - 1 < 0)
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {snake.FoodQuantiny}");
                        PrintMatrix(matrix);
                        break;
                    }
                    else
                    {
                        snake.SnakeRow--;
                    }

                    if (matrix[snake.SnakeRow, snake.SnakeCol] == '*')
                    {
                        snake.FoodQuantiny++;
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == 'B')
                    {
                        Burrow exitBurrow = burrows.FirstOrDefault(b => b.BurrowRow != snake.SnakeRow && b.BurrowCol != snake.SnakeCol);
                        snake.SnakeRow = exitBurrow.BurrowRow;
                        snake.SnakeCol = exitBurrow.BurrowCol;
                        matrix[burrows[0].BurrowRow, burrows[0].BurrowCol] = '.';
                        matrix[burrows[1].BurrowRow, burrows[1].BurrowCol] = '.';
                    }
                    else if(matrix[snake.SnakeRow, snake.SnakeCol] == '-')
                    {
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }
                }
                else if (command == "down")
                {
                    if (snake.SnakeRow + 1 >= n)
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {snake.FoodQuantiny}");
                        PrintMatrix(matrix);
                        break;
                    }
                    else
                    {
                        snake.SnakeRow++;
                    }

                    if (matrix[snake.SnakeRow, snake.SnakeCol] == '*')
                    {
                        snake.FoodQuantiny++;
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == 'B')
                    {
                        Burrow exitBurrow = burrows.FirstOrDefault(b => b.BurrowRow != snake.SnakeRow && b.BurrowCol != snake.SnakeCol);
                        snake.SnakeRow = exitBurrow.BurrowRow;
                        snake.SnakeCol = exitBurrow.BurrowCol;
                        matrix[burrows[0].BurrowRow, burrows[0].BurrowCol] = '.';
                        matrix[burrows[1].BurrowRow, burrows[1].BurrowCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == '-')
                    {
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }
                }
                else if (command == "right")
                {
                    if (snake.SnakeCol + 1 >= n)
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {snake.FoodQuantiny}");
                        PrintMatrix(matrix);
                        break;
                    }
                    else
                    {
                        snake.SnakeCol++;
                    }

                    if (matrix[snake.SnakeRow, snake.SnakeCol] == '*')
                    {
                        snake.FoodQuantiny++;
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == 'B')
                    {
                        Burrow exitBurrow = burrows.FirstOrDefault(b => b.BurrowRow != snake.SnakeRow && b.BurrowCol != snake.SnakeCol);
                        snake.SnakeRow = exitBurrow.BurrowRow;
                        snake.SnakeCol = exitBurrow.BurrowCol;
                        matrix[burrows[0].BurrowRow, burrows[0].BurrowCol] = '.';
                        matrix[burrows[1].BurrowRow, burrows[1].BurrowCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == '-')
                    {
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }


                }

                else if (command == "left")
                {
                    if (snake.SnakeCol - 1 < 0)
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {snake.FoodQuantiny}");
                        PrintMatrix(matrix);
                        break;
                    }
                    else
                    {
                        snake.SnakeCol--;
                    }

                    if (matrix[snake.SnakeRow, snake.SnakeCol] == '*')
                    {
                        snake.FoodQuantiny++;
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == 'B')
                    {
                        Burrow exitBurrow = burrows.FirstOrDefault(b => b.BurrowRow != snake.SnakeRow && b.BurrowCol != snake.SnakeCol);
                        snake.SnakeRow = exitBurrow.BurrowRow;
                        snake.SnakeCol = exitBurrow.BurrowCol;
                        matrix[burrows[0].BurrowRow, burrows[0].BurrowCol] = '.';
                        matrix[burrows[1].BurrowRow, burrows[1].BurrowCol] = '.';
                    }
                    else if (matrix[snake.SnakeRow, snake.SnakeCol] == '-')
                    {
                        matrix[snake.SnakeRow, snake.SnakeCol] = '.';
                    }

                }
                if (snake.FoodQuantiny >= 10)
                {
                    matrix[snake.SnakeRow, snake.SnakeCol] = 'S';
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {snake.FoodQuantiny}");
                    PrintMatrix(matrix);
                    break;
                }
            }
        }

        private static char[,] GetMatrix(int n)
        {
            var matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static Snake GetSnake(char[,] matrix)
        {
            int rowElement = -1;
            int colElement = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        rowElement = row;
                        colElement = col;
                    }
                }

            }

            Snake snake = new Snake(rowElement, colElement);
            return snake;
        }

        static List<Burrow> GetBurrows(char[,] matrix)
        {
            int rowElement = -1;
            int colElement = -1;
            List<Burrow> burrows = new List<Burrow>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        rowElement = row;
                        colElement = col;
                        Burrow burrow = new Burrow(rowElement, colElement);
                        burrows.Add(burrow);
                    }
                }

            }


            return burrows;
        }
    }
}
