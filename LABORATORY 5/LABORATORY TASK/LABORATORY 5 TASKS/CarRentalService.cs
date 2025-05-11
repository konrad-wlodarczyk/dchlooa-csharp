using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    class CarRentalService
    {
        private readonly VehicleFactory carFactory;

        public CarRentalService(VehicleFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public void Rent()
        {
            Vehicle v = carFactory.Create();

            Console.WriteLine("Our rental service can offer you the following car today: ");
            Console.WriteLine(v);
        }
    }
}
