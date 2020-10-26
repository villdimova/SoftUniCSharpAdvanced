using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01.Bombs
{
    public class Bomb
    {
        public Bomb(string name, int material, int count)
        {
            this.Name = name;
            this.Material = material;

        }
        public string Name { get; set; }
        public int Material { get; set; }
        public int Count { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var effects = new Queue<int>(inputOne);

            var inputTwo = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var casings = new Stack<int>(inputTwo);

            var bombPouch = new List<Bomb>();
            int count = Math.Min(effects.Count, casings.Count);
            bool successfullyFilled = false;
            Bomb bombDatura = new Bomb("Datura Bombs", 40, 0);
            Bomb bombCherry = new Bomb("Cherry Bombs", 60, 0);
            Bomb bombSmokeDekoy = new Bomb("Smoke Decoy Bombs", 120, 0);
            


            while (effects.Count > 0 && casings.Count > 0)
            {

                if (bombCherry.Count >= 3 && bombDatura.Count >= 3 && bombSmokeDekoy.Count >= 3)
                {
                    successfullyFilled = true;
                    break;

                }

                else
                {
                    int sum = effects.Peek() + casings.Peek();
                    if (sum == 40 || sum == 60 || sum == 120)
                    {
                        effects.Dequeue();
                        casings.Pop();
                        if (sum == 40)
                        {

                            bombDatura.Count++;

                        }
                        else if (sum == 60)
                        {

                            bombCherry.Count++;

                        }
                        else if (sum == 120)
                        {
                            bombSmokeDekoy.Count++;

                        }

                    }
                    else
                    {
                        int newBombCasing = casings.Peek() - 5;
                        casings.Pop();
                        casings.Push(newBombCasing);
                    }
                }

            }

            if (successfullyFilled == true)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ", effects)}");
            }

            if (casings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ", casings)}");
            }
            bombPouch.Add(bombCherry);
            bombPouch.Add(bombDatura);
            bombPouch.Add(bombSmokeDekoy);
            foreach (var bomb in bombPouch.OrderBy(b => b.Name))
            {
                Console.WriteLine($"{bomb.Name}: {bomb.Count}");
            }
        }

        
    }
}
