using System;
using System.Numerics;

namespace _02.Re_Volt
{
    public class Player
    {
        public Player(int playerRow, int playerCol)
        {
            this.PlayerRow = playerRow;
            this.PlayerCol = playerCol;
        }

        public int PlayerRow { get; set; }
        public int PlayerCol { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countComands = int.Parse(Console.ReadLine());
            var matrix = GetMatrix(n);

            Player player = GetPlayer(matrix);
            matrix[player.PlayerRow, player.PlayerCol] = '-';
            for (int i = 0; i < countComands; i++)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    player.PlayerRow--;
                    CheckIndexes(matrix, player, n);

                    while (matrix[player.PlayerRow, player.PlayerCol] != '-' && matrix[player.PlayerRow, player.PlayerCol] != 'F')
                    {
                        if (matrix[player.PlayerRow, player.PlayerCol] == 'B')
                        {
                            player.PlayerRow--;
                            CheckIndexes(matrix, player, n);

                        }
                        else if (matrix[player.PlayerRow, player.PlayerCol] == 'T')
                        {
                            player.PlayerRow++;
                            CheckIndexes(matrix, player, n);
                        }
                    }
                    if (matrix[player.PlayerRow, player.PlayerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[player.PlayerRow, player.PlayerCol] = 'f';
                        PrintMatrix(matrix);
                        return;
                    }


                }
                else if (command == "down")
                {
                    player.PlayerRow++;
                    CheckIndexes(matrix, player, n);

                    while (matrix[player.PlayerRow, player.PlayerCol] != '-' && matrix[player.PlayerRow, player.PlayerCol] != 'F')
                    {
                        if (matrix[player.PlayerRow, player.PlayerCol] == 'B')
                        {
                            player.PlayerRow++;
                            CheckIndexes(matrix, player, n);

                        }
                        else if (matrix[player.PlayerRow, player.PlayerCol] == 'T')
                        {
                            player.PlayerRow--;
                            CheckIndexes(matrix, player, n);
                        }
                    }

                    if (matrix[player.PlayerRow, player.PlayerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[player.PlayerRow, player.PlayerCol] = 'f';
                        PrintMatrix(matrix);
                        return;
                    }
                }
                else if (command == "right")
                {
                    player.PlayerCol++;
                    CheckIndexes(matrix, player, n);


                    while (matrix[player.PlayerRow, player.PlayerCol] != '-' && matrix[player.PlayerRow, player.PlayerCol] != 'F')
                    {
                        if (matrix[player.PlayerRow, player.PlayerCol] == 'B')
                        {
                            player.PlayerCol++;
                            CheckIndexes(matrix, player, n);

                        }
                        else if (matrix[player.PlayerRow, player.PlayerCol] == 'T')
                        {
                            player.PlayerCol--;
                            CheckIndexes(matrix, player, n);
                        }
                    }

                    if (matrix[player.PlayerRow, player.PlayerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[player.PlayerRow, player.PlayerCol] = 'f';
                        PrintMatrix(matrix);
                        return;
                    }

                }
                else if (command == "left")
                {

                    player.PlayerCol--;
                    CheckIndexes(matrix, player, n);



                    while (matrix[player.PlayerRow, player.PlayerCol] != '-' && matrix[player.PlayerRow, player.PlayerCol] != 'F')
                    {
                        if (matrix[player.PlayerRow, player.PlayerCol] == 'B')
                        {
                            player.PlayerCol--;
                            CheckIndexes(matrix, player, n);

                        }
                        else if (matrix[player.PlayerRow, player.PlayerCol] == 'T')
                        {
                            player.PlayerCol++;
                            CheckIndexes(matrix, player, n);
                        }
                    }

                    if (matrix[player.PlayerRow, player.PlayerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[player.PlayerRow, player.PlayerCol] = 'f';
                        PrintMatrix(matrix);
                        return;
                    }

                }

            }

            matrix[player.PlayerRow, player.PlayerCol] = 'f';
            Console.WriteLine("Player lost!");
            PrintMatrix(matrix);
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

        static Player GetPlayer(char[,] matrix)
        {
            int rowElement = -1;
            int colElement = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        rowElement = row;
                        colElement = col;
                    }
                }

            }

            Player element = new Player(rowElement, colElement);
            return element;
        }

        static void CheckIndexes(char[,] matrix, Player player, int n)
        {
            if (player.PlayerRow < 0)
            {
                player.PlayerRow = n - 1;
            }
            if (player.PlayerCol < 0)
            {
                player.PlayerCol = n - 1;
            }
            if (player.PlayerRow == n)
            {
                player.PlayerRow = 0;
            }
            if (player.PlayerCol == n)
            {
                player.PlayerCol = 0;
            }
        }
    }
}
