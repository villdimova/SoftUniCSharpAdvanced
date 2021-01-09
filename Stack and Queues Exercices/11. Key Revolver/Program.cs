using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var bulletsStack = new Stack<int>(bullets);
            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var locksQueue = new Queue<int>(locks);
            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletCounter = 0;

            while (bulletsStack.Count > 0)
            {
                if (locksQueue.Count == 0)
                {
                    break;
                }
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                bulletsStack.Pop();
                bulletCounter++;
                intelligenceValue -= priceBullet;

                if (bulletCounter == sizeGunBarrel)
                {
                    if (bulletsStack.Count > 0)
                    {
                        bulletCounter = 0;
                        Console.WriteLine("Reloading!");
                    }

                }

            }


            if (locksQueue.Count == 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligenceValue}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }




        }
    }
}
