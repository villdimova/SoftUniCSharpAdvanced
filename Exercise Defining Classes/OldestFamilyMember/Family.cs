using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Oldest_Family_Member
{
    public class Family
    {
        public List<Person> FamilyMembers { get; set; }

        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMemeber()
        {

            var oldestPerson = FamilyMembers
             .OrderByDescending(p => p.Age)
             .FirstOrDefault();

            return oldestPerson;

        }
    }
}
