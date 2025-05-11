using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class FuelDiesel : Fuel
    {
        public override string Type { get; }

        public FuelDiesel()
        {
            this.Type = "Diesel";
            density = 1;
        }

        public FuelDiesel(double volume, double weight) : base(volume, weight, 1) 
        {
            this.Type = "Diesel";
        }

        public new string GetType()
        {
            return "Diesel";
        }
    }
}
