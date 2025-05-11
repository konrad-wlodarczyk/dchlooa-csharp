using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Submarine
    {
		
		
        // this is the actual submarine simulation
        public static void Demo()
        {
            // recruit crew
            Crewman crewman1 = new Crewman();
            Crewman crewman2 = new Crewman();
            Equipment probe1 = new Equipment();
            Equipment probe2 = new Equipment();
            Scientist scientist1 = new Scientist(probe1);
            Scientist scientist2 = new Scientist(probe2);
            List<Human> crew = new List<Human>() { crewman1, crewman2, scientist1, scientist2 };
            // build life support system
            Waste waste = new Waste();
            waste.Volume = 0.0;
            FoodContainer container = new FoodContainer(200.0);
            container.Volume = 200.0;
            OxygenBottle bottle1 = new OxygenBottle(10000.0);
            OxygenBottle bottle2 = new OxygenBottle(10000.0);
            bottle1.Volume = bottle2.Volume = 10000.0;
            List<OxygenBottle> bottles = new List<OxygenBottle>() { bottle1, bottle2 };
            LifeSupportSystem system = new LifeSupportSystem(bottles, container, waste, crew);
            // build engine
            FuelNuclear fuel = new FuelNuclear();
            FuelTank tank = new FuelTank(50.0, fuel);
            tank.Volume = tank.MaxCapacity;
            Engine engie = new Engine(tank, waste);
            // all transportable items will contribute to total weight
            List<ITransportable> transportables = new List<ITransportable>() { probe1, probe2, crewman1, crewman2,
                scientist1, scientist2, waste, container, bottle1, bottle2, fuel, tank };
            double baseWeight = 1000.0;
            double totalWeight = baseWeight;
            foreach (ITransportable item in transportables) totalWeight += item.Weight;
            Console.WriteLine("Initial submarine weight: " + totalWeight);
            // we also want to remember all items we need to take care of when visiting a port
            List<IVisitPort> itemsToRemember = new List<IVisitPort>() { waste, container, bottle1, bottle2, tank };




            // a number of different travel options
            List<double> tripDistances = new List<double>() { 10.0, 250.0, 1e3, 1e6 };
            foreach(double distance in tripDistances)
            {
                Console.WriteLine();
                // calculate total weight
                totalWeight = baseWeight;
                foreach (ITransportable item in transportables) totalWeight += item.Weight;
                Console.WriteLine("Current submarine weight: " + totalWeight);
                // how much time would it take to travel?
                double time = distance / engie.GetVelocity(totalWeight);
                // do we have enough fuel?
                if (!engie.CheckFuelBeforeTravel(time)) 
                {
                    Console.WriteLine("Not enough fuel to travel " + distance + " km!");
                    Console.WriteLine("Available fuel: " + tank.Volume);
                    Console.WriteLine("Required travel time: " + time.ToString(".#") + " hours");
                    continue;
                }
                // do we have enough supplies?
                if (!system.CheckSuppliesBeforeTravel(time))
                {
                    Console.WriteLine("Not enough supplies to travel " + distance + " km!");
                    Console.WriteLine("Available food: " + container.Volume);
                    Console.WriteLine("Available oxygen: " + (bottle1.Volume + bottle2.Volume));
                    Console.WriteLine("Required travel time: " + time.ToString(".#") + " hours");
                    continue;
                }
                // if everything is ok - let's go on a trip!
                Console.WriteLine("Travel destination accepted [" + distance + " km]");
                engie.Travel(time);
                system.Run(time);
                scientist1.Work(time);
                scientist2.Work(time);
                // for comparison, calculate total weight again
                totalWeight = baseWeight;
                foreach (ITransportable item in transportables) totalWeight += item.Weight;
                Console.WriteLine("Current submarine weight: " + totalWeight.ToString("."));
                // back to the port - let's see how much did it cost
                double totalCost = 0.0;
                foreach (IVisitPort item in itemsToRemember) totalCost += item.VisitPort();
                Console.WriteLine("Total trip cost: " + totalCost.ToString("."));
                // now repeat for a different travel option
            } 
        }

		
    }
}
