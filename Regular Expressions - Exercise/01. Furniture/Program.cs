using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            Regex regex = new Regex(@"\>>(?<type>[A-Z][A-Z]?[a-z]*)\<<(?<price>\d+\.?\d*)\!(?<quantity>\d+)\b");
            List<string> boughtFurniture = new List<string>();
            decimal sum = 0;
           

            //>>Sofa<<312.23!3

            while ((input = Console.ReadLine()) != "Purchase")
            {
               
                bool validText = regex.IsMatch(input);

                if (validText == true)
                {
                    Match match = regex.Match(input);
                    string furnitureType = match.Groups["type"].Value;
                    decimal furniturePrice = decimal.Parse(match.Groups["price"].Value);
                    int furnitureQuantiny = int.Parse(match.Groups["quantity"].Value);

                    boughtFurniture.Add(furnitureType);
                    sum += furniturePrice * furnitureQuantiny;


                }



               

            }

            Console.WriteLine("Bought furniture:");
            boughtFurniture = boughtFurniture.ToList();

            foreach (var item in boughtFurniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
