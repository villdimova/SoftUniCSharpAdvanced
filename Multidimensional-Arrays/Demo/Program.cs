using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int currRow = 0; currRow < n; currRow++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[currRow] = currentRow;
            }


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    foreach (var item in jagged)
                    {
                        Console.WriteLine(String.Join(" ", item));
                    }
                    break;
                }

                else
                {
                    var command = input.Split();
                    string commandName = command[0];
                    int rowIndex = int.Parse(command[1]);
                    int colIndex = int.Parse(command[2]);
                    int num = int.Parse(command[3]);

                    if (rowIndex<  0 || rowIndex >= n || colIndex < 0 || colIndex >= jagged[rowIndex].Length)

                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }

                    if (commandName.Contains("Add"))

                    {
                        jagged[rowIndex][colIndex] += num;
                    }


                    if (commandName.Contains("Subtract"))
                    {
                        jagged[rowIndex][colIndex] -= num;
                    }
                }


            }

           
        }
    }
}
