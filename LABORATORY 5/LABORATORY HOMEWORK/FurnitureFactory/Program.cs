
using FurnitureFactory;

class Program
{
    static void Main(string[] args)
    {
        List<InteriorDesigner> designers = new List<InteriorDesigner>
        {
            new ClassicDesigner(),
            new ModernDesigner(),
            new ScandinavianDesigner(),
            new VictorianDesigner()
        };

        int[] priceLimits = { 5000, 10000, 15000 };

        foreach (var designer in designers)
        {
            Console.WriteLine($"--- {designer.GetType().Name} ---");

            foreach (int price in priceLimits)
            {
                var desk = designer.ProduceDesk(price);
                var wardrobe = designer.ProduceWardrobe(price);

                Console.WriteLine($"Price Limit: {price}");
                Console.WriteLine("Desk: " + (desk != null ? desk.Description() : "Cannot produce desk"));
                Console.WriteLine("Wardrobe: " + (wardrobe != null ? wardrobe.Description() : "Cannot produce wardrobe"));
                Console.WriteLine();
            }
        }
    }
}
