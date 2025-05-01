using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    class Animal
    {
        public string Name;
        protected int weight;
        private int age;

        public Animal() 
        {
            Name = "noname";
            weight = 0;
        }

        public Animal(string name, int weight)
        {
            this.Name = name;
            this.weight = weight;
        }

    }
}
