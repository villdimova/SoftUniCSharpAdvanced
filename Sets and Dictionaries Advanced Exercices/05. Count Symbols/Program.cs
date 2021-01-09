using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var symbols = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols.Add(text[i], 1);
                }

                else
                {
                    symbols[text[i]]++;
                }
            }

            symbols = symbols
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
