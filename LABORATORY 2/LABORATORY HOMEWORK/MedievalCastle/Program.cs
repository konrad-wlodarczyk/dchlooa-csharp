using System;
using System.Collections.Generic;

namespace MedievalCastle
{
    class Program
    {
        static void Main()
        {
            List<Crossbowman> Crossbowmen = new List<Crossbowman>();
            List<Pikeman> Pikemen = new List<Pikeman>();
            List<Defender> Defender = new List<Defender>();
            List<Resident> Residents = new List<Resident>();
            List<Civilian> Civilians = new List<Civilian>();

            Crossbowman crossbowman1 = new Crossbowman("Konrad", 22, 50);
            Crossbowman crossbowman2 = new Crossbowman("Mateusz", 23, 35);

            Pikeman pk1 = new Pikeman("Aleksander", 60, "Glaive");
            Pikeman pk2 = new Pikeman("Szymon", 27, "Spear?");

            Civilian civilian1 = new Civilian("Joanna", 51, "Vegetable shop");
            Civilian civilian2 = new Civilian("Dariusz", 51, "Finances");

            Crossbowmen.Add(crossbowman1);
            Crossbowmen.Add(crossbowman2);
            Pikemen.Add(pk1);
            Pikemen.Add(pk2);
            Civilians.Add(civilian1);
            Civilians.Add(civilian2);
            Defender.Add(crossbowman1);
            Defender.Add(crossbowman2);
            Defender.Add(pk1);
            Defender.Add(pk2);
            Residents.Add(crossbowman1);
            Residents.Add(crossbowman2);
            Residents.Add(pk1);
            Residents.Add(pk2);
            Residents.Add(civilian1);
            Residents.Add(civilian2);

            Console.WriteLine("Are the crossbowmen ready to fight?:");
            foreach (var cbm in Crossbowmen)
            {
                Console.WriteLine(cbm.ReadyToFight());
            }

            Console.WriteLine("\nAre all of the defenders ready to fight?");
            foreach (var defender in Defender)
            {
                Console.WriteLine(defender.ReadyToFight());
            }

            Console.WriteLine("\nInfo about all residents: ");
            foreach (var resident in Residents)
            {
                Console.WriteLine(resident.ToString());
                Console.WriteLine(resident.Eat());
                Console.WriteLine();
            }

        }
    }
}
