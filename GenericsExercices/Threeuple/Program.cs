using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threeuple
{
   public class Program
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            var drinkInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var bankInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            sb.Append(personInfo[0]);
            sb.Append(" ");
            sb.Append(personInfo[1]);
            string fullName = sb.ToString();
            string address = personInfo[2];
            string town = "";
            if (personInfo.Length>4)
            {
                town = personInfo[3] + " " + personInfo[4];
            }
            else
            {
              town = personInfo[3];
            } 
            
            Threeuple<string, string,string> threeuplePerson = new Threeuple<string, string,string>(fullName,address,town);
            Console.WriteLine(threeuplePerson.GetInfo());

            string name = drinkInfo[0];
            int countBeers = int.Parse(drinkInfo[1]);
            string drunk = drinkInfo[2];
           
            if (drunk=="drunk")
            {
                drunk = "True";
            }
            else
            {
                drunk = "False";
            }
            Threeuple<string, int,string> threeupleBeersCount = new Threeuple<string, int,string>(name, countBeers,drunk);
            Console.WriteLine(threeupleBeersCount.GetInfo());


            string nameOwner = bankInfo[0];
            double accountBalance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];


            Threeuple<string, double,string> bankThreeuple = new Threeuple<string, double,string>(nameOwner, accountBalance,bankName);
            Console.WriteLine(bankThreeuple.GetInfo());
        }
    }
}
