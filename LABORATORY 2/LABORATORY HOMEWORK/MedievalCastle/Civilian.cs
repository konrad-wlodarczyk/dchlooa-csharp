using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalCastle
{
    class Civilian : Resident
    {
        public string errand {  get; set; }

        public Civilian(string Name, int age, string errand) : base(Name, age)
        {
            this.errand = errand;
        }

        public override string Eat()
        {
            return $"The civilian {Name} needs one apple to replenish his vitals.";
        }

        public override string ToString()
        {
            return $"Type of resident: Civilian, Name: {Name}, Age: {age}, Errands: {errand}";
        }
    }
}
