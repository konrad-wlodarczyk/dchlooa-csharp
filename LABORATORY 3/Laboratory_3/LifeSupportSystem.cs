using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles {  get; set; }
        private FoodContainer foodContainer { get; set; }
        private Waste waste { get; set; }
        private List<Human> crew {  get; set; }

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            oxygenBottles = bottles;
            foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {

            double requiredOxygen = crew.Count * 2 * travelTime;
            double requiredFood = crew.Count * 1 * travelTime;
            double availableOxygen = 0;

            foreach (var bottle in oxygenBottles)
            {
                availableOxygen += bottle.Volume;
            }

            bool hasEnoughOxygen = availableOxygen >= requiredOxygen;
            bool hasEnoughFood = foodContainer.Volume >= requiredFood;


            return hasEnoughOxygen && hasEnoughFood;
        }
 

        public void Run(double travelTime)
        {
            if(!CheckSuppliesBeforeTravel(travelTime))
            {
                Console.WriteLine("Insufficient supplies...");
                return;
            }

            double requiredOxygen = crew.Count * 2 * travelTime;
            double requiredFood = crew.Count * 1 * travelTime;
            double wasteProduced = requiredFood * 1;

            foreach (var bottle in oxygenBottles)
            {
                if (requiredOxygen <= 0) break;
                double used = Math.Min(bottle.GetMaxCapacity(), requiredOxygen);
                bottle.Volume -= used;
                requiredOxygen -= used;
            }

            foodContainer.Volume -= requiredFood;
            waste.Volume += wasteProduced;
        }

    }
}
