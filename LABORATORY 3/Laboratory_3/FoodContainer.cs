using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class FoodContainer : IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity { get; set; }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 4.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 4.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }

        public FoodContainer(double maxCapacity)
        {
            MaxCapacity = maxCapacity;
        }

        public double GetMaxCapacity()
        {
            return MaxCapacity;
        }

        public double VisitPort()
        {
            Volume = MaxCapacity;
            Weight = Volume * 4;
            return 6.33;
        }
    }
}
