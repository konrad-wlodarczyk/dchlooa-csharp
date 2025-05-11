using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    class CityTransportFactory : TransportFactory
    {
        private Vehicle lastVehicle;

        public override Vehicle CreateVehicle()
        {
            switch (travelMode)
            {
                case "quickest":
                    lastVehicle = new Metro();
                    break;
                case "cheapest":
                    lastVehicle = new Bike();
                    break;
                case "convenient":
                    lastVehicle = new Car("Hybrid", 180, "Toyota", 2021);
                    break;
                default:
                    Console.WriteLine("Invalid travel preference.");
                    lastVehicle = null;
                    break;
            }
            return lastVehicle;
        }

        public override Ticket CreateTicket()
        {
            if (lastVehicle is Metro) return new MetroTicket();
            return null;
        }
    }
}
