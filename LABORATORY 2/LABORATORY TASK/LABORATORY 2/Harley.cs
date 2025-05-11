using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    internal class Harley : Vehicle
    {
        public Harley(string engineType, int maxSpeed) : base(engineType, maxSpeed) { }

        public override string GetVehicleType()
        {
            return $"Type of vehicle: Harley.";
        }
    }
}
