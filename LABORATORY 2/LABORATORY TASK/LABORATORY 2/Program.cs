namespace LABORATORY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Train("Electric", 800));
            vehicles.Add(new Harley("Dwusów", 250));
            vehicles.Add(new Buggy("VW Beetle engine", 90));

            foreach (Vehicle v in vehicles) Console.WriteLine(v);

            TicketMaster ticketMaster = new TicketMaster();
            ticketMaster.BuyTicket();

        }
    }
}
