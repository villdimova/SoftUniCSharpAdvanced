using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex =new Regex (@"(\d{2})(\W)([A-Z]{1}[a-z]{2})\2(\d{4})");

            string dates = Console.ReadLine();

            MatchCollection validDates = regex.Matches(dates);

            foreach (Match date in validDates)
            {
               
               
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }

        }
    }
}
