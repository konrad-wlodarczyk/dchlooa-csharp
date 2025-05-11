using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace C3
{
    class Engine
    {
        private FuelTank tank {  get; set; }
        private Waste waste { get; set; }

        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            double velocity = 0.5 * submarineWeight;
            return velocity;
        }

        public bool CheckFuelBeforeTravel(double travelTime)
        {
            double requiredFuel = travelTime * 4;
            return tank.Volume >= requiredFuel;
        }

        public void Travel(double travelTime)
        {
            if(CheckFuelBeforeTravel(travelTime))
            {
                double fuelConsumed = travelTime * 4;
                tank.Volume -= fuelConsumed;

                waste.Volume += fuelConsumed * 0.7;
            }
            else
            {
                Console.WriteLine("Can't travel, not enough fuel.");
            }
        }
    }
}
