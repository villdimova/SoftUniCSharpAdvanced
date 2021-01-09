using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\+359([ |-])2\1\d{3}\1\d{4}");
            string phones = Console.ReadLine();
            
            var matches = regex.Matches(phones);

            var matchedPhones = matches
                .Cast<Match>()
                .Select(x=>x.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ", matchedPhones));

            
        }
    }
}
