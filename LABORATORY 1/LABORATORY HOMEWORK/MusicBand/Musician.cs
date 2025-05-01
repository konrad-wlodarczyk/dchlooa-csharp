using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Musician : Person
    {
        protected int experience {  get; set; }

        public Musician(string name, int age, int experience) : base(name, age)
        {
            this.experience = experience;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Has {experience} years of experience as a musician.");
        }
    }
}
