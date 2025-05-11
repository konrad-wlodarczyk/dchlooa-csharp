using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MedievalCastle
{
    class Pikeman : Defender
    {
        public string pikeType { get; set; }

        public Pikeman(string Name, int age, string pikeType) : base(Name, age, "Pike")
        {
            this.pikeType = pikeType;
        }

        public override string Eat()
        {
            return $"The pikeman {Name} needs two shots of whiskey to stand on his feet.";
        }

        public override string ReadyToFight()
        {
            return $"The pikeman {Name} is ready to fight.";
        }

        public override string ToString()
        {
            return $"Type of resident: Defender, Pikeman, Name: {Name}, Age: {age}, Weapon: pike, Type: {pikeType}";
        }
    }
}
