using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Vocalist : Musician
    {
        protected string vocalType {  get; set; } //Lead, Harmonies, Backup and similar to those.

        public Vocalist(string name, int age, int experience, string vocalType) : base(name, age, experience)
        {
            this.vocalType = vocalType;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"{name} is a {vocalType} vocalist.");
        }

        public void Sing(string song)
        {
            Console.WriteLine();
            Console.WriteLine($"{name} starts singing '{song}'.");
        }
    }
}
