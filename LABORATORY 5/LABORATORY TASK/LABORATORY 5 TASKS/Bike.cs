using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    class Bike : Vehicle
    {
        public Bike() : base("None", 30) { }

        public override string GetVehicleType() => "Type of vehicle: bike";
    }
}
