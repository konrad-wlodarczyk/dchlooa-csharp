using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    class Flamingo : Bird
    {
        public Flamingo() : base() { }

        public Flamingo(string name, int weight, int numberOfFeathers) : base(name, weight, numberOfFeathers) { }

        public void SecondRefer()
        {
            //The accessibility stays the same as in the Bird class, since the derived class inherited 
            //accessibility rules from Bird
            Console.WriteLine("Name: " + Name); //Accessible - Public field.
            Console.WriteLine("Weight: " + weight); //Accessible - Protected field.
            //Console.WriteLine("Age: " + age); //Inaccessible - private field.
        }

        public void Incubation(int number, int days)
        {
            LayEggs(number);
            Console.WriteLine($"The {number} eggs are incubated for {days} days.");
        }
    }
}
