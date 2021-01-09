using System;
using System.Collections.Generic;
using System.Linq;


namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pumpInfo = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(pumpInfo);
            }

            int counter = 0;

            while (true)
            {
                int fuelAmount = 0;
                bool foundPump = true;


                for (int i = 0; i < n; i++)
                {
                    int[] currentPump = pumps.Dequeue();
                    fuelAmount += currentPump[0];

                    if (fuelAmount < currentPump[1])
                    {
                        foundPump = false;

                    }

                    fuelAmount -= currentPump[1];
                    pumps.Enqueue(currentPump);

                }

                if (foundPump)
                {
                    break;
                }

                counter++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(counter);
        }

    }
}

