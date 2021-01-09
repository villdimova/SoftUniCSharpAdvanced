using System;
using System.Linq;
using _03._Oldest_Family_Member;
using DefiningClasses;

namespace _03._Oldest_Family_Member
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var memberInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                var memberName = memberInfo[0];
                var memberAge = int.Parse(memberInfo[1]);

                Person person = new Person(memberName, memberAge);

                family.AddMember(person);

            }

            var oldestMember = family.GetOldestMemeber();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

        }
    }
}
