using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    class Bird : Animal
    {
        private int numberOfFeathers;

        public Bird() : base()
        {
            numberOfFeathers = 0;
        }

        public Bird(string name, int weight, int numberOfFeathers) : base(name, weight)
        {
            this.numberOfFeathers = numberOfFeathers;
        }
        public void Refer()
        {
            Console.WriteLine("Name: " + Name); //Accessible - Public field.
            Console.WriteLine("Weight: " + weight); //Accessible - Protected field.
            //Console.WriteLine("Age: " + age); //Inaccessible - private field.
        }

        public void LayEggs(int number)
        {
            Console.WriteLine($"{Name} laid {number} eggs.");
        }
    }
}
