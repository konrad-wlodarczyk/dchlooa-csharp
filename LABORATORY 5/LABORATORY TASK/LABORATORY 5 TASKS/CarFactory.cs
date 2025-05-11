using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    class CarFactory : VehicleFactory
    {
        private Random rand = new Random();

        public override Vehicle Create()
        {
            string[] brands = { "Toyota", "Kia", "BMW", "Ford", "Subaru", "Honda" };
            int[] years = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008 };

            string brand = brands[rand.Next(brands.Length)];
            int year = years[rand.Next(years.Length)];
            string engine = $"{brand} Standard Engine";
            int maxSpeed = rand.Next(150, 200);

            return new Car(engine, maxSpeed, brand, year);
        }
    }
}
