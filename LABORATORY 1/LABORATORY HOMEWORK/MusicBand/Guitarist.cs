using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Guitarist : Instrumentalist
    {
        protected string guitarType {  get; set; }

        public Guitarist(string name, int age, int experience, string guitarType) : base(name, age, experience, "guitar")
        {
            this.guitarType = guitarType;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Type of guitar: {guitarType} guitar.");
        }

        public override void Perform(string song)
        {
            Console.WriteLine();
            Console.WriteLine($"{name} shreds an amazing {guitarType} guitar '{song}' solo.");
        }
    }
}
