using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Garden
{
    public class Plant
    {
        public Plant(int plantRow, int plantCol)
        {
            this.PlantRow = plantRow;
            this.PlantCol = plantCol;
        }

        public int PlantRow { get; set; }
        public int PlantCol { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = demensions[0];
            int m = demensions[1];
            var matrix = CreateGarden(n, m);
            var plants = new Queue<Plant>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bloom Bloom Plow")
                {
                   
                    break;
                }
                else
                {
                    var plantCoordinates = input.Split().Select(int.Parse).ToArray();
                    int rowPlant = plantCoordinates[0];
                    int colPlant = plantCoordinates[1];

                    Plant plant = new Plant(rowPlant, colPlant);

                    if (plant.PlantRow < 0 || plant.PlantCol < 0 || plant.PlantRow >= n || plant.PlantCol >= m)
                    {
                        Console.WriteLine("Invalid coordinates.");
                        continue;
                    }
                    else
                    {
                        matrix[rowPlant, colPlant] += 1;
                        plants.Enqueue(plant);
                    }


                }
            }

            if (plants.Count>0)
            {
                BloomPlants(n, m, matrix, plants);
            }

            
            PrintMatrix(matrix);
    }

        static int[,] CreateGarden(int n, int m)
        {
            var matrix = new int[n, m];
            var currentRow = new int[n];
            for (int row = 0; row < n; row++)
            {
                currentRow[row] = 0;

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = currentRow[row];
                }
            }

            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void BloomPlants(int n, int m, int[,] matrix, Queue<Plant> plants)
        {
            while (plants.Count>0)
            {
                Plant currentPlant = plants.Dequeue();
                int plantRow = currentPlant.PlantRow;
                int plantCol = currentPlant.PlantCol;
                for (int i = 0; i < m; i++)
                {
                    if (i != plantCol)
                      matrix[plantRow, i] += 1;

                }
                for (int i = 0; i < n; i++)
                {
                    if (i!=plantRow)
                    {
                        matrix[i, plantCol] += 1;
                    }
                   

                }
            }
           
        }
    }
}



