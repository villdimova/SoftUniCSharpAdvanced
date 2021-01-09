using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            int difference=dateModifier.GetDiffrenceInDaysBetweenTwoDates(firstDate, secondDate);

            Console.WriteLine(Math.Abs(difference));
            
        }
    }
}
