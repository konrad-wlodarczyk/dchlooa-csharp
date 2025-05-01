using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Instrumentalist : Musician
    {
        protected string instrument { get; set; }

        public Instrumentalist(string name, int age, int experience, string instrument) : base(name, age, experience)
        {
            this.instrument = instrument;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"{name} plays the {instrument}.");
        }

        public virtual void Perform(string song)
        {
            Console.WriteLine();
            Console.WriteLine($"{name} plays '{song}' on the {instrument}.");
        }
    }
}
