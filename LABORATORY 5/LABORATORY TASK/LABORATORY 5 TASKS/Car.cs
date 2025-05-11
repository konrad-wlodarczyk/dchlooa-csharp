using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    internal class Car : Vehicle
    {
        private string brand;
        private int year;

        public Car(string engineType, int maxSpeed, string brand, int year): base(engineType, maxSpeed) 
        {
            this.brand = brand;
            this.year = year;
        }

        public override string GetVehicleType()
        {
            return $"Type of vehicle: Car";
        }

        public override string ToString()
        {
            return base.ToString() + $" Brand: {brand} Year: {year}";
        }
    }
}
