using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternChars = @"[^0-9+\/*\.-]";
            string patternDigit = @"-?\d+\.?\d*";
            string patternSign = @"[*\/]";


            string[] input = Console.ReadLine()
                .Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x=>x)
                .ToArray();

            

            Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();
            
           
            foreach (var item in input)
            {
                double baseDamage = 0;
                double health = 0;

                MatchCollection matches = Regex.Matches(item, patternChars);

                foreach (Match character in matches)
                {
                    health += char.Parse(character.Value);
                }

                MatchCollection matchDigits = Regex.Matches(item, patternDigit);

                foreach (Match digit in matchDigits)
                {
                    baseDamage += double.Parse(digit.Value);
                }

                MatchCollection matchSigns = Regex.Matches(item, patternSign);

                foreach (Match sign in matchSigns)
                {
                    
                    if (sign.Value=="*")
                    {
                        baseDamage *= 2;
                    }

                    else if (sign.Value=="/")
                    {
                        baseDamage /= 2;
                    }
                }

                if (!demons.ContainsKey(item))
                {
                    demons.Add(item, new List<double>());
                }

                demons[item].Add(health);
                demons[item].Add(baseDamage);

                Console.WriteLine($"{item} - {health} health, {baseDamage:f2} damage ");
            }


            
        }
    }
}
