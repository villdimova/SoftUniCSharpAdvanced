using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string pattern = (@"[sStTaArR]");
            List<string> planetInfos = new List<string>();


            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                var matches = Regex.Matches(input, pattern);
                int count = matches.Count;
                string decriptedMessage = String.Empty;
                

                foreach (var item in input)
                {
                    decriptedMessage += (char)(item - count);
                }

                planetInfos.Add(decriptedMessage);
            }
            string patternPlanetInfo = @"([^@!:>-]*)@(?<planet>[A-Za-z]+)([^@!:>-]*?):(?<population>\d+)([^@!:>-]*?)!(?<type>[AD])!([^@!:>-]*?)->(?<soldiers>\d+)([^@!:>-]*)";


            List<string> destroyedPlanets = new List<string>();
            List<string> attackeddPlanets = new List<string>();

            foreach (var item in planetInfos)
            {
                var match = Regex.Match(item, patternPlanetInfo);

                if (match.Success)
                {
                   
                    if (match.Groups["type"].Value=="A")
                    {
                        attackeddPlanets.Add(match.Groups["planet"].Value);
                    }

                    else if (match.Groups["type"].Value == "D")
                    {
                        destroyedPlanets.Add(match.Groups["planet"].Value);
                    }
                }

                
            }

            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();
            attackeddPlanets = attackeddPlanets.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attackeddPlanets.Count}");
            if (attackeddPlanets.Count > 0)
            {
                foreach (var attackedPlanet in attackeddPlanets)
                {
                    Console.WriteLine($"-> {attackedPlanet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var destroyedPlanet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {destroyedPlanet}");
                }
            }




        }
    }
}
