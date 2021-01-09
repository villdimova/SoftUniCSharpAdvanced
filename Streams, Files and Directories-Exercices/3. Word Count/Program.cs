using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchedWords = new Dictionary<string, int>();
            string inputPath = "../../../input.txt";
            string outputPath = "../../../output.txt";
            string expectedResult = "../../../expected.txt";
            string wordsPath = "../../../words.txt";

            string[] words = File.ReadAllLines(wordsPath);
            string originalText = File.ReadAllText(inputPath);
            var textWords = originalText.Split(new char[] { ',', '.', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < textWords.Length; j++)
                {

                    if (words[i].ToLower() == textWords[j].ToLower())
                    {
                        if (!matchedWords.ContainsKey(textWords[j].ToLower()))
                        {
                            matchedWords.Add(textWords[j].ToLower(), 1);
                        }
                        else
                        {
                            matchedWords[textWords[j].ToLower()]++;
                        }

                    }
                }
            }

            foreach (var word in matchedWords.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(outputPath, $"{word.Key} - {word.Value}{Environment.NewLine}");
            }

            

           

        }


    }
}
