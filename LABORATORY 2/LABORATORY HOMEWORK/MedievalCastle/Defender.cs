using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalCastle
{
    class Defender : Resident, IDefender
    {
        public string weapon {  get; set; }

        public Defender(string Name, int age,  string weapon) : base(Name, age)
        {
            this.weapon = weapon;
        }

        public override string Eat()
        {
            return $"The defender {Name} needs 2 slices of bread to satisfy his hunger.";
        } 

        public virtual string ReadyToFight()
        {
            return $"The defender {Name} is ready to fight.";
        }

        public override string ToString()
        {
            return $"Type of resident: Defender, Name: {Name}, Age: {age}, weapon: {weapon}";
        }
    }
}
