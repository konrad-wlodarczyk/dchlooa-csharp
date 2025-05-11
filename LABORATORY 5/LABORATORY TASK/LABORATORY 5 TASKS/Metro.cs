using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    class Metro : Vehicle
    {
        public Metro() : base("Electric", 200) { }

        public override string GetVehicleType() => "Type of vehicle: Metro";
    }
}
