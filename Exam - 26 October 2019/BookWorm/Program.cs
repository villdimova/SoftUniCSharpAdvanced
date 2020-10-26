using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine();
            StringBuilder stringInput = new StringBuilder();
            stringInput.Append(input);

            int playerRow = 0;
            int playerCol = 0;
            int n = int.Parse(Console.ReadLine());

            var matrix = GetMatrix(n);
            var personCoordinates = GetPersonCoordinates(matrix);
            int rowPerson = personCoordinates[0];
            int colPerson = personCoordinates[1];

            matrix[rowPerson, colPerson] = '-';
            while (true)
            {
                string direction = Console.ReadLine();
                if (direction=="end")
                {
                    matrix[rowPerson, colPerson] = 'P';
                    Console.WriteLine(stringInput);
                    PrintMatrix(matrix);
                    break;
                }

                else
                {
                    if (direction=="up")
                    {
                        if (rowPerson-1<0)
                        {
                            if (stringInput.Length>0)
                            {
                                stringInput.Remove(stringInput.Length-1,1);
                            }
                            

                        }
                        else
                        {
                            rowPerson--;
                            
                            if (char.IsLetter(matrix[rowPerson,colPerson]))
                            {
                                stringInput.Append(matrix[rowPerson, colPerson]);
                                matrix[rowPerson, colPerson] = '-';
                            }
                            else
                            {
                                continue;
                            }
                        }

                       
                       
                    }
                    else if (direction=="down")
                    {
                        if (rowPerson + 1 >= n)
                        {
                            if (stringInput.Length > 0)
                            {
                                stringInput.Remove(stringInput.Length-1,1);
                            }


                        }
                        else
                        {
                            rowPerson++;
                           
                            if (char.IsLetter(matrix[rowPerson, colPerson]))
                            {
                                stringInput.Append(matrix[rowPerson, colPerson]);
                                matrix[rowPerson, colPerson] = '-';
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                    else if (direction=="left")
                    {
                        if (colPerson - 1 < 0)
                        {
                            if (stringInput.Length > 0)
                            {
                                stringInput.Remove(stringInput.Length - 1, 1);
                            }


                        }
                        else
                        {
                            colPerson--;
                           
                            if (char.IsLetter(matrix[rowPerson, colPerson]))
                            {
                                stringInput.Append(matrix[rowPerson, colPerson]);
                                matrix[rowPerson, colPerson] = '-';
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (direction=="right")
                    {
                        if (colPerson + 1 >=n)
                        {
                            if (stringInput.Length > 0)
                            {
                                stringInput.Remove(stringInput.Length - 1, 1);
                            }


                        }
                        else
                        {
                            colPerson++;
                            if (char.IsLetter(matrix[rowPerson, colPerson]))
                            {
                                stringInput.Append(matrix[rowPerson, colPerson]);
                                matrix[rowPerson, colPerson] = '-';
                            }

                            else
                            {
                                continue;
                            }
                        }
                    }
                }    
            }


        }

        private static int[] GetPersonCoordinates(char[,] matrix)
        {
            int[] matrixCoordinates = new int[2];
            int rowPerson = -1;
            int colPerson = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        rowPerson = row;
                        colPerson = col;
                        break;
                    }
                }
            }

            matrixCoordinates[0] = rowPerson;
            matrixCoordinates[1] = colPerson;
            return matrixCoordinates;
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
    }
}
