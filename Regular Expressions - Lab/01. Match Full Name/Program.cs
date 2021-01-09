using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z]{1}[a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matches = regex.Matches(names);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }
        }
    }
}
