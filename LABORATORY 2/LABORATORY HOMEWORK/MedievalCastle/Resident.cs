using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalCastle
{
    abstract class Resident
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Resident()
        {
            Name = "unknown";
            age = 0;
        }

        public Resident(string Name, int age)
        {
            this.Name = Name;
            this.age = age;
        }

        public abstract string Eat();
        public abstract override string ToString();

    }
}
