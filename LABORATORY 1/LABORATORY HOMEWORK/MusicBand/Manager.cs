using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Manager : Person
    {
        protected string responsibilites {  get; set; }

        public Manager(string name, int age, string responsibilites) : base(name, age)
        {
            this.responsibilites = responsibilites;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"{name} is the manager of the band.");
            Console.WriteLine("Responsibilites: " + responsibilites);
        }

        public void Manage()
        {
            Console.WriteLine();
            Console.WriteLine($"{name} is performing his managing duties.");
        }
    }
}
