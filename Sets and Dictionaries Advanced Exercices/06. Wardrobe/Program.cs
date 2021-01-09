using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                var colour = input[0];
                var clothes = input[1]
                    .Split(",")
                    .ToArray();

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentClothing = clothes[j];

                    if (!wardrobe[colour].ContainsKey(currentClothing))
                    {
                        wardrobe[colour].Add(currentClothing, 1);
                    }
                    else
                    {
                        wardrobe[colour][currentClothing]++;
                    }
                }

            }

            var wanted = Console.ReadLine().Split().ToArray();

            var wantedColour = wanted[0];
            var wantedClothing = wanted[1];

            foreach (var item in wardrobe)
            {

                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothing in item.Value)
                {
                    if (item.Key == wantedColour && clothing.Key == wantedClothing)

                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }



                }
            }

        }
    }
}
