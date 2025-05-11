using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class FuelNuclear : Fuel
    {
        public override string Type { get; }
        public FuelNuclear()
        {
            this.Type = "Nuclear";
            density = 15;
        }

        public FuelNuclear(double volume, double weight) : base(volume, weight, 15)
        {
            this.Type = "Nuclear";
        }

        public new string GetType()
        {
            return "Nuclear";
        }
    }
}
