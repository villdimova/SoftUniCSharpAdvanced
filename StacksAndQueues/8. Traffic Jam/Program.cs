using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {

            int numPassing = int.Parse(Console.ReadLine());
            int countCars = 0;
            var queue =new Queue<string>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    Console.WriteLine($"{countCars} cars passed the crossroads.");
                    break;
                }
                else if (input== "green")
                {
                    
                    for (int i = 0; i < numPassing; i++)
                    {
                        if (queue.Count>0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            countCars++;
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
