using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            List<int> orders = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queueOrders = new Queue<int>(orders);

            Console.WriteLine(queueOrders.Max());

            int numOrders = orders.Count();

            for (int i = 0; i < numOrders; i++)
            {
                if (quantityFood >= queueOrders.Peek())
                {
                    quantityFood -= queueOrders.Peek();
                    queueOrders.Dequeue();
                }
            }

            if (queueOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queueOrders)}");
            }

        }
    }
}

