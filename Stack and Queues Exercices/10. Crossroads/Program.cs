using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int countPassedCars = 0;
            var queue = new Queue<string>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{countPassedCars} total cars passed the crossroads.");
                    break;
                }
                else if (input == "green")
                {
                    int timeForPassing = greenDuration + freeWindow;
                    int greenTime = greenDuration;

                    while (queue.Count > 0)
                    {
                        int lengthCar = queue.Peek().Length;

                        if (greenTime > 0)
                        {
                            if (lengthCar <= timeForPassing)
                            {
                                timeForPassing -= lengthCar;
                                greenTime -= lengthCar;
                                queue.Dequeue();
                                countPassedCars++;
                            }

                            else
                            {
                                Console.WriteLine("A crash happened!");
                                string currentCar = queue.Peek();
                                int HitIndex = timeForPassing;
                                Console.WriteLine($"{currentCar} was hit at {currentCar.Substring(HitIndex, 1)}.");
                                return;
                            }
                        }

                        else
                        {
                            break;
                        }

                    }

                }

                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}

