using System;

namespace WaterDroplet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Water droplet starts in the cloud
            Context droplet = new Context(new CloudState());
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Cloud -> Plant
            droplet.Percipitation("plant");
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Plant -> Cloud
            droplet.Respiration();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Cloud -> River
            droplet.Percipitation("river");
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //River -> Ocean
            droplet.FlowsInto();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Ocean -> Cloud
            droplet.Evaporation();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Cloud -> Well
            droplet.Percipitation("well");
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Well -> Human
            droplet.Drinking();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Human -> PurificationStation
            droplet.Excreting();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //PurificationStation -> River
            droplet.Purifying();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //River -> Animal
            droplet.Drinking();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            //Animal -> Cloud
            droplet.Respiration();
            Console.WriteLine(droplet.GetInfo());
            Console.WriteLine("----------");

            Console.WriteLine("\nSimulation complete.");
        }
    }
}