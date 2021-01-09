using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                var personName = personInfo[0];
                var personAge = int.Parse(personInfo[1]);

                Person person = new Person(personName, personAge);
                persons.Add(person);

            }

            foreach (var item in persons.Where(p=>p.Age>30).OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
