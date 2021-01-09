using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string input = String.Empty;
            
            string regex = @"\%(?<customer>[A-Z]{1}[a-z]+)\%[^|$%\.]*\<(?<product>\w+)\>[^|$%\.]*\|(?<count>\d+)\|[^|$%\.]*?(?<price>\d+\.*\d*)\$";

            double totalSum = 0;


            while ((input=Console.ReadLine())!= "end of shift")
            {
    
                if (Regex.IsMatch(input,regex))
                {


                    Match match = Regex.Match(input, regex);
                    var customer = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value;
                    var count = int.Parse(match.Groups["count"].Value);
                    var price = double.Parse(match.Groups["price"].Value);

                    double productPrice = price * count;


                    Console.WriteLine($"{customer}: {product} - {productPrice:f2}");
                    totalSum += productPrice;
                }

                
                
            }

            Console.WriteLine($"Total income: {totalSum:f2}");


        }
    }
}
