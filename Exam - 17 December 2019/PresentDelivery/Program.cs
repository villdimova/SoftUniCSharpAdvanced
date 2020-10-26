using System;
using System.Linq;

namespace PresentDelivery
{
    public class Santa
    {

        public Santa(int santaRow,int santaCol,int presentsCount)
        {
            this.SantaRow = santaRow;
            this.SantaCol = santaCol;
            this.PresentsCount = presentsCount;
        }
        public int SantaRow { get; set; }

        public int SantaCol { get; set; }

        public int PresentsCount { get; set; }

        
       
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countPresents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var matrix = GetMatrix(n);
            //PrintMatrix(matrix);
            //S-Santa coordinates
            //X-naughty kid no present
            //C cooky=>good Santa=> presents all kids around-up,down, left, right. Position C

            int goodKidsNum = GetGoodKidsNum(matrix);
            int presentsGoodKids = 0;
            Santa santa = GetSanta(matrix, countPresents);
            matrix[santa.SantaRow, santa.SantaCol] = "-";

            while (true)
            {
                string position = Console.ReadLine();

                if (position== "Christmas morning")
                {
                    
                    matrix[santa.SantaRow, santa.SantaCol] = "S";
                    PrintMatrix(matrix);

                    if (presentsGoodKids==goodKidsNum)
                    {
                        Console.WriteLine($"Good job, Santa! {presentsGoodKids} happy nice kid/s.");
                    }
                    else
                    {
                        Console.WriteLine($"No presents for {goodKidsNum-presentsGoodKids} nice kid/s.");
                    }

                    break;
                }
                else
                {
                    if (position=="up")
                    {
                        if (santa.SantaRow-1>=0)
                        {
                            santa.SantaRow--;
                            if (matrix[santa.SantaRow,santa.SantaCol]=="V")
                            {
                                presentsGoodKids++;
                                santa.PresentsCount--;
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "X")
                            {
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                                continue;
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "C")
                            {
                                presentsGoodKids += HappySanta(santa, matrix);
                            }
                        }
                        else
                        {
                            continue;
                        }
                        
                    }

                    else if (position == "down")
                    {
                        if (santa.SantaRow + 1 < n)
                        {
                            santa.SantaRow++;
                            if (matrix[santa.SantaRow, santa.SantaCol] == "V")
                            {
                                presentsGoodKids++;
                                santa.PresentsCount--;
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "X")
                            {
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                                continue;
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "C")
                            {
                                presentsGoodKids += HappySanta(santa, matrix);
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }

                    else if (position == "left")
                    {
                        if (santa.SantaCol - 1 >=0)
                        {
                            santa.SantaCol--;
                            if (matrix[santa.SantaRow, santa.SantaCol] == "V")
                            {
                                presentsGoodKids++;
                                santa.PresentsCount--;
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "X")
                            {
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                                continue;
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "C")
                            {
                                presentsGoodKids += HappySanta(santa, matrix);
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }

                    else if (position == "right")
                    {
                        if (santa.SantaCol + 1<n)
                        {
                            santa.SantaCol++;
                            if (matrix[santa.SantaRow, santa.SantaCol] == "V")
                            {
                                presentsGoodKids++;
                                santa.PresentsCount--;
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "X")
                            {
                                matrix[santa.SantaRow, santa.SantaCol] = "-";
                                continue;
                            }
                            else if (matrix[santa.SantaRow, santa.SantaCol] == "C")
                            {
                                presentsGoodKids += HappySanta(santa, matrix);
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }

                    if (santa.PresentsCount == 0)
                    {
                        Console.WriteLine("Santa ran out of presents!");


                        matrix[santa.SantaRow, santa.SantaCol] = "S";
                        PrintMatrix(matrix);

                        if (presentsGoodKids == goodKidsNum)
                        {
                            Console.WriteLine($"Good job, Santa! {presentsGoodKids} happy nice kid/s.");
                        }
                        else
                        {
                            Console.WriteLine($"No presents for {goodKidsNum - presentsGoodKids} nice kid/s.");
                        }

                        break;
                    }
                }


            }
            
        }
        private static string[,] GetMatrix(int n)
        {
            var matrix = new string[n, n];
            for (int row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]+" ");
                }
                Console.WriteLine();
            }
        }

        static int GetGoodKidsNum(string[,] matrix)
        {
            int goodKidsNum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]== "V")
                    {
                        goodKidsNum++;
                    }
                }
            }

            return goodKidsNum;
        }


        static Santa GetSanta(string[,] matrix,int countPresents)
        {
            int santaRow = -1;
            int santaCol = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "S")
                    {
                         santaRow = row;
                        santaCol = col;
                    }
                }
            }

            Santa santa = new Santa(santaRow, santaCol, countPresents);

            return santa;
        }

        static int HappySanta(Santa santa,string[,] matrix)
        {
            int presentsGoodKidsFromHappy=0;

            if (matrix[santa.SantaRow - 1, santa.SantaCol] == "V")
            {
                presentsGoodKidsFromHappy++;
                santa.PresentsCount--;
                matrix[santa.SantaRow - 1, santa.SantaCol] = "-";
            }
            if (matrix[santa.SantaRow + 1, santa.SantaCol] == "V")
            {
                presentsGoodKidsFromHappy++;
                santa.PresentsCount--;
                matrix[santa.SantaRow + 1, santa.SantaCol] = "-";
            }
            if (matrix[santa.SantaRow, santa.SantaCol - 1] == "V")
            {
                presentsGoodKidsFromHappy++;
                santa.PresentsCount--;
                matrix[santa.SantaRow, santa.SantaCol - 1] = "-";
            }
            if (matrix[santa.SantaRow, santa.SantaCol + 1] == "V")
            {
                presentsGoodKidsFromHappy++;
                santa.PresentsCount--;
                matrix[santa.SantaRow, santa.SantaCol + 1] = "-";
            }

            if (matrix[santa.SantaRow - 1, santa.SantaCol] == "X")
            {
                santa.PresentsCount--;
                matrix[santa.SantaRow - 1, santa.SantaCol] = "-";
            }
            if (matrix[santa.SantaRow + 1, santa.SantaCol] == "X")
            {

                santa.PresentsCount--;
                matrix[santa.SantaRow + 1, santa.SantaCol] = "-";
            }
            if (matrix[santa.SantaRow, santa.SantaCol - 1] == "X")
            {

                santa.PresentsCount--;
                matrix[santa.SantaRow, santa.SantaCol - 1] = "-";
            }
            if (matrix[santa.SantaRow, santa.SantaCol + 1] == "X")
            {

                santa.PresentsCount--;
                matrix[santa.SantaRow, santa.SantaCol + 1] = "-";
            }

            return presentsGoodKidsFromHappy;
        }
    }
}
