using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)(?<user>[a-zA-Z0-9]+[.-]*\w*)*@(?<host>[a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))";

            string input = Console.ReadLine();

            var validMails = Regex.Matches(input, pattern);

            foreach (Match mail in validMails)
            {
                Console.WriteLine(mail.Value);
            }
        }
    }
}
