using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            CustomStack<string> stack = new CustomStack<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                var commands = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var commandName = commands[0];
                if (commandName == "Push")
                {
                    var items = commands.Skip(1).ToArray();
                    foreach (var item in items)
                    {
                        stack.Push(item);
                    }

                }
                else if (commandName == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }


            }

            try
            {
                for (int i = 0; i < 2; i++)
               {
                   foreach (var item in stack)
                   {
                    Console.WriteLine(item);
                }
              }
            }
            catch (InvalidOperationException exception)
            {

                Console.WriteLine(exception.Message);
            }

        }
    }
}


        
         
       