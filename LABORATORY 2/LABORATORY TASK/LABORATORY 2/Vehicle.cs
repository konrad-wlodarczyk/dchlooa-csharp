using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    abstract internal class Vehicle
    {
        protected string engineType { get; set; }
        protected int maxSpeed { get; set; }

        public Vehicle()
        {
            engineType = "unspecified";
            maxSpeed = 0;
        }

        public Vehicle(string engineType, int maxSpeed)
        {
            this.engineType = engineType;
            this.maxSpeed = maxSpeed;
        }

        public abstract string GetVehicleType();

        public override string ToString()
        {
            return $"Vehicle type: {GetVehicleType()}. Engine: {engineType}. Max speed: {maxSpeed}";
        }

    }
}
