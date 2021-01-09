using DefiningClasses;
using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Ivan",34);
            

            Person secondPerson = new Person("Maria",25);
            

            Console.WriteLine($"{firstPerson.Name}----{firstPerson.Age}");
            Console.WriteLine($"{secondPerson.Name}----{secondPerson.Age}");
        }
    }
}
