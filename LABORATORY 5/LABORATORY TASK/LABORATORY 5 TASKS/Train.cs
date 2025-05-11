using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    internal class Train : Vehicle
    {
        public Train()
        {
            engineType = "unspecified";
            maxSpeed = 0;
        }
        public Train(string engineType, int maxSpeed) : base(engineType, maxSpeed) { }
        public override string GetVehicleType()
        {
            return "Type of vehicle: train";
        }

    }
}
