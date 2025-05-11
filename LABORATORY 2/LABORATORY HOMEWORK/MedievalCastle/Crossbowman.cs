using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalCastle
{
    class Crossbowman : Defender
    {
        public int numberOfArrows {  get; set; }

        public Crossbowman(string Name, int age, int numberOfArrows) : base(Name, age, "Crossbow")
        {
            this.numberOfArrows = numberOfArrows;
        }

        public override string Eat()
        {
            return $"The crossbowman {Name} needs 3 glasses of moonshine to hit his enemy.";
        }

        public override string ReadyToFight()
        {
            return $"The crossbowman {Name} is ready to fight.";
        }

        public override string ToString()
        {
            return $"Type of resident: Defender, Crossbowman, Name: {Name}, Age: {age}, Weapon: crossbow, Arrow number: {numberOfArrows}";
        }
    }
}
