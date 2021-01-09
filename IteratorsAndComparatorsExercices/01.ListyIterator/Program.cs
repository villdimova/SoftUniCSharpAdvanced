using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
   public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<string> elements = command
                            .Split()
                            .Skip(1)
                            .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            command = Console.ReadLine();

            while (true)
            {

                if (command == "END")
                {
                    break;
                }
                else
                {

                    if (command == "Print")
                    {
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Invalid operation!");
                        }

                    }

                    else if (command == "Move")
                    {
                        bool result = listyIterator.Move();
                        Console.WriteLine(result);
                    }

                    else if (command == "HasNext")
                    {
                        bool hasNext = listyIterator.HasNext();
                        Console.WriteLine(hasNext);
                    }

                    command = Console.ReadLine();

                }
            }
        }
    }
}
