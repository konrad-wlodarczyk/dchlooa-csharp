using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class Scientist : Human
    {
        private Equipment equipment { get; set; }

        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
        }

        public void Work(double time)
        {
            Console.WriteLine($"Working time of the scientist: {time}");
        }
    }
}
