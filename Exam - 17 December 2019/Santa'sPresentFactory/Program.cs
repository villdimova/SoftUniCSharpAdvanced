using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_sPresentFactory
{
    public class Present
    {
        public string Name { get; set; }
        public int MagicNeeded { get; set; }
        public int Count { get; set; }

        public Present(string name, int magicNeeded, int count)
        {
            this.Name = name;
            this.MagicNeeded = magicNeeded;
            this.Count = count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var presents = new List<Present>();
            var doll = new Present("Doll", 150,0);
            var woodenTrain = new Present("Wooden train", 250,0);
            var teddyBear = new Present("Teddy bear", 300,0);
            var bicycle = new Present("Bicycle", 400,0);
            presents.Add(doll);
            presents.Add(woodenTrain);
            presents.Add(teddyBear);
            presents.Add(bicycle);

            
            var firstInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var materials = new Stack<int>(firstInput);

            var secondInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var magics = new Queue<int>(secondInput);

            while (materials.Count != 0 && magics.Count != 0)
            {
                int totalMagicLevel = materials.Peek() * magics.Peek();

                if (presents.Any(p => p.MagicNeeded == totalMagicLevel))
                {
                    Present currentPresent = presents.First(p => p.MagicNeeded == totalMagicLevel);
                    currentPresent.Count++;
                    materials.Pop();
                    magics.Dequeue();
                }

                else
                {
                    if (totalMagicLevel==0)
                    {
                        if (materials.Peek()==0&&magics.Peek()==0)
                        {
                            materials.Pop();
                            magics.Dequeue();
                            continue;

                        }
                        else if (materials.Peek()==0)
                        {
                            materials.Pop();
                            continue;
                        }
                        else if (magics.Peek()==0)
                        {
                            magics.Dequeue();
                            continue;
                        }
                    }

                    else
                    {
                        if (totalMagicLevel < 0)
                        {
                            int sum = materials.Peek() + magics.Peek();
                            int newMaterialValue =sum;
                            materials.Pop();
                            magics.Dequeue();
                            materials.Push(newMaterialValue);
                        }
                        else if (totalMagicLevel > 0)
                        {
                            magics.Dequeue();
                            int newMaterialValue = materials.Peek() + 15;
                            materials.Pop();
                            materials.Push(newMaterialValue);

                        }
                    }
 
                }
            }

            List<Present> craftedPresents = new List<Present>();
            foreach (var present in presents)
            {
                if (present.Count>0)
                {
                    craftedPresents.Add(present);
                }
            }
            if ((craftedPresents.Any(p=>p.Name== "Doll")&&craftedPresents.Any(p=>p.Name== "Wooden train"))|| (craftedPresents.Any(p => p.Name == "Teddy bear") && craftedPresents.Any(p => p.Name == "Bicycle")))

            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
                
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Count>0)
            {
                Console.WriteLine($"Materials left: {String.Join(", ",materials)}");
            }

            if (magics.Count > 0)
            {
                Console.WriteLine($"Magic left: {String.Join(", ", magics)}");
            }

            foreach (var present in craftedPresents.OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{present.Name}: {present.Count}");
            }
        }
    }
}
