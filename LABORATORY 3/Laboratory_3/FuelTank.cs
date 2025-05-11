using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class FuelTank : IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity { get; set; }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }

        public Fuel fuel { get; set; }

        public FuelTank(double maxCapacity, Fuel fuel)
        {
            MaxCapacity = maxCapacity;
            this.fuel = fuel;
        }

        public double GetMaxCapacity()
        {
            return MaxCapacity;
        }

        public string GetFuelType()
        {
            return $"Fuel Type: {fuel}";
        }

        public double VisitPort()
        {
            double fuelNeeded = MaxCapacity - Volume;

            if(fuelNeeded <= 0)
            {
                Console.WriteLine("Wacha do pełna zalana.");
                return 0;
            }

            double price = 0;

            if(fuel.GetType() == "Diesel")
            {
                price = fuelNeeded * 21.38;
            }
            if(fuel.GetType() == "Nuclear")
            {
                price = fuelNeeded * 420.69;
            }

            Volume = MaxCapacity;
            weight = Volume * 7;

            return price;
        }
    }
}
