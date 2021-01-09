using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public string Name { get; set; }

        public int Age { get; set; }


    }
}
