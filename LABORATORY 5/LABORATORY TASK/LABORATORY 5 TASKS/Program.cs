namespace LABORATORY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VehicleFactory> factories = new List<VehicleFactory>() { new TrainFactory(),
            new BusFactory(),  new CarFactory()};

            foreach (VehicleFactory factory in factories)
            {
                Vehicle v = factory.Create();
                Console.WriteLine(v);
            }

            CarRentalService rentalService = new CarRentalService(new CarFactory());
            rentalService.Rent();

            TransportFactory cityFactory = new CityTransportFactory();
            cityFactory.TravelMode = "cheapest";
            Vehicle cityVehicle = cityFactory.CreateVehicle();
            Ticket cityTicket = cityFactory.CreateTicket();

            Console.WriteLine($"City travel - Vehicle: {cityVehicle}");
            Console.WriteLine($"City travel - Ticket: {(cityTicket == null ? "No ticket required" : cityTicket.GetTicketInfo())}");

            TransportFactory intercityFactory = new IntercityTransportFactory();
            intercityFactory.TravelMode = "convenient";
            Vehicle intercityVehicle = intercityFactory.CreateVehicle();
            Ticket intercityTicket = intercityFactory.CreateTicket();

            Console.WriteLine($"\nIntercity travel - Vehicle: {intercityVehicle}");
            Console.WriteLine($"Intercity travel - Ticket: {(intercityTicket == null ? "No ticket required" : intercityTicket.GetTicketInfo())}");

        }
    }
}
