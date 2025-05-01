using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Person
    {
        protected string name { get; set; }
        protected int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void DisplayInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
