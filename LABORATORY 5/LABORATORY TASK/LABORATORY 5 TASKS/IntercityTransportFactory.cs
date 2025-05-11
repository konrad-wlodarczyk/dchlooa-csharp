using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    class IntercityTransportFactory : TransportFactory
    {
        private Vehicle lastVehicle;

        public override Vehicle CreateVehicle()
        {
            switch (travelMode)
            {
                case "quickest":
                    lastVehicle = new Train("Electric", 300);
                    break;
                case "cheapest":
                    lastVehicle = new Bus("Diesel", 100);
                    break;
                case "convenient":
                    lastVehicle = new Train("Electric", 250); // same as quickest, but conceptually different
                    break;
                default:
                    Console.WriteLine("Invalid travel mode.");
                    lastVehicle = null;
                    break;
            }
            return lastVehicle;
        }

        public override Ticket CreateTicket()
        {
            if (lastVehicle is Train) return new TrainTicket();
            if (lastVehicle is Bus) return new BusTicket();
            return null;
        }
    }
}
