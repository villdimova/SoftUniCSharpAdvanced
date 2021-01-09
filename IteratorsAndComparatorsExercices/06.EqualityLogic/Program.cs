using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Person> persons = new HashSet<Person>();
            SortedSet<Person> personsSorted = new SortedSet<Person>();

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split().ToArray();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                persons.Add(person);
                personsSorted.Add(person);
            }
 
            Console.WriteLine(persons.Count);
            Console.WriteLine(personsSorted.Count);





        }
    }
}
