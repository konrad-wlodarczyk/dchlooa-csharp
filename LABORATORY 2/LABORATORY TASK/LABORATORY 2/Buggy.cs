using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    internal class Buggy : Vehicle
    {
        public Buggy(string engineType, int maxSpeed): base(engineType, maxSpeed) { }

        public override string GetVehicleType()
        {
            return $"Type of vehicle: Buggy.";
        }
    }
}
