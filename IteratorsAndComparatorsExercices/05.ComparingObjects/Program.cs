using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    var personInfo = input.Split().ToArray();
                    var name = personInfo[0];
                    var age = int.Parse(personInfo[1]);
                    var town = personInfo[2];
                    Person person = new Person(name, age, town);
                    persons.Add(person);
                }
            }

            int index = int.Parse(Console.ReadLine());

            
            int equalPersons = 1;
            int differentPersons = 0;

            for (int i = 0; i < persons.Count; i++)
            {
                if (i==index-1)
                {
                    continue;
                }
                else
                {
                    if (persons[index-1].CompareTo(persons[i])==0)
                    {
                        equalPersons++;
                    }
                    else
                    {
                        differentPersons++;
                    }
                }
            }
            

            if (equalPersons<2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPersons} {differentPersons} {persons.Count}");
            }

        }
    }
}
