using System;
using System.Data;

namespace _02.Bee
{
    public class Bee
    {
        public Bee(int rowBee,int colBee)
        {
            this.RowBee = rowBee;
            this.ColBee = colBee;
        }
        public int RowBee { get; set; }

        public int ColBee { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = GetMatrix(n);

            Bee bee = GetBee(matrix);
            int pollinatedFlowers = 0;
            matrix[bee.RowBee, bee.ColBee] = '.';
            
            while (true)
            {
                string direction = Console.ReadLine();
                if (direction == "End")
                {
                    if (pollinatedFlowers < 5)
                    {
                        matrix[bee.RowBee, bee.ColBee] = 'B';
                        Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
                        PrintMatrix(matrix);
                        return;
                    }
                    else
                    {
                        matrix[bee.RowBee, bee.ColBee] = 'B';
                        Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
                        PrintMatrix(matrix);
                        return;
                    }
                }
                else
                {
                    if (direction == "up")
                    {
                        if (bee.RowBee - 1 < 0)
                        {
                           
                            break;
                        }
                        else
                        {
                            bee.RowBee--;
                            if (matrix[bee.RowBee, bee.ColBee] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[bee.RowBee, bee.ColBee] = '.';
                            }
                            else if (matrix[bee.RowBee, bee.ColBee] == 'O')
                            {
                                matrix[bee.RowBee, bee.ColBee] = '.';
                                if (bee.RowBee - 1 < 0)
                                {
                                   
                                    break;
                                }
                                else
                                {
                                    bee.RowBee--;
                                    if (matrix[bee.RowBee, bee.ColBee] == 'f')
                                    {
                                        pollinatedFlowers++;
                                        matrix[bee.RowBee, bee.ColBee] = '.';
                                    }
                                }
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        if (bee.RowBee + 1 >= n)
                        {
                            
                            break;
                        }
                        else
                        {
                            bee.RowBee++;
                            if (matrix[bee.RowBee, bee.ColBee] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[bee.RowBee, bee.ColBee] = '.';
                            }
                            else if (matrix[bee.RowBee, bee.ColBee] == 'O')
                            {
                                matrix[bee.RowBee, bee.ColBee] = '.';
                                if (bee.RowBee + 1 >= n)
                                {
                                  
                                    break;
                                }
                                else
                                {
                                    bee.RowBee++;
                                    if (matrix[bee.RowBee, bee.ColBee] == 'f')
                                    {
                                        pollinatedFlowers++;
                                        matrix[bee.RowBee, bee.ColBee] = '.';
                                    }
                                }
                            }


                           
                        }
                    }
                    else if (direction == "right")
                    {
                        if (bee.ColBee + 1 >= n)
                        {
                           
                            break;
                        }
                        else
                        {
                            bee.ColBee++;
                            if (matrix[bee.RowBee, bee.ColBee] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[bee.RowBee, bee.ColBee] = '.';
                            }
                            else if (matrix[bee.RowBee, bee.ColBee] == 'O')
                            {
                                matrix[bee.RowBee, bee.ColBee] = '.';
                                if (bee.ColBee + 1 >= n)
                                {
                                    
                                    break;
                                }
                                else
                                {
                                    bee.ColBee++;
                                    if (matrix[bee.RowBee, bee.ColBee] == 'f')
                                    {
                                        pollinatedFlowers++;
                                        matrix[bee.RowBee, bee.ColBee] = '.';
                                    }
                                }
                            }

                        }
                    }
                    else if (direction == "left")
                    {
                        if (bee.ColBee - 1 < 0)
                        {
                           
                            break;
                        }
                        else
                        {
                            bee.ColBee--;
                            if (matrix[bee.RowBee, bee.ColBee] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[bee.RowBee, bee.ColBee] = '.';
                            }
                            else if (matrix[bee.RowBee, bee.ColBee] == 'O')
                            {
                                matrix[bee.RowBee, bee.ColBee] = '.';
                                if (bee.ColBee - 1 < 0)
                                {
                                    
                                    break;
                                }
                                else
                                {
                                    bee.ColBee--;
                                    if (matrix[bee.RowBee, bee.ColBee] == 'f')
                                    {
                                        pollinatedFlowers++;
                                        matrix[bee.RowBee, bee.ColBee] = '.';
                                    }
                                }
                            }
                        }
                    }
                }
            }

            
                Console.WriteLine("The bee got lost!");
                if (pollinatedFlowers < 5)
                {
                    Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
                    PrintMatrix(matrix);
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

        static Bee GetBee(char[,] matrix)
        {
            int rowBee = -1;
            int colBee = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col]=='B')
                    {
                        rowBee = row;
                        colBee = col;
                    }
                }
               
            }

            Bee bee = new Bee(rowBee, colBee);
            return bee;
        }


    }
}
