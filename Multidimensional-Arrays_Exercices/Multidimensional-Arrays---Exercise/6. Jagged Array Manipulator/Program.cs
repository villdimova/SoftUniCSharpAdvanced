using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow;

            }

            for (int row = 0; row < rows-1; row++)
            {
                if (jaggedArray[row].Length==jaggedArray[row+1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                       
                    }

                    for (int i = 0; i < jaggedArray[row+1].Length; i++)
                    {
                        jaggedArray[row+1][i] *= 2;
                    }
                }

                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                        
                       

                    }

                    for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                    {
                        jaggedArray[row+1][i] /= 2;
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input== "End")
                {
                    foreach (var item in jaggedArray)
                    {
                        Console.WriteLine(String.Join(" ", item));
                    }

                    break;
                }

                else
                {
                    var command = input.Split();
                    int rowIndex = int.Parse(command[1]);
                    int colIndex = int.Parse(command[2]);
                    int number = int.Parse(command[3]);

                    if (command.Contains("Add"))
                    {
                        

                        if (rowIndex>=0
                            &&rowIndex<rows
                            &&colIndex>=0
                            &&colIndex<jaggedArray[rowIndex].Length)
                        {
                            jaggedArray[rowIndex][colIndex] += number;
                        }
                    }

                    else if (command.Contains("Subtract"))
                    {
                        if (rowIndex >= 0
                            && rowIndex < rows
                            && colIndex >= 0
                            && colIndex < jaggedArray[rowIndex].Length)
                        {
                            jaggedArray[rowIndex][colIndex] -= number;
                        }
                    }
                }
            }
        }
    }
}
