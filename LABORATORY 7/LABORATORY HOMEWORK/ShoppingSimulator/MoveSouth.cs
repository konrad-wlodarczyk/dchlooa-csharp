using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSimulator
{
    class MoveSouth : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going south...cause they'll let you play your music real damn loud.");

            if((currentTime > 6 && currentTime < 9) || (currentTime > 15 && currentTime < 18))
            {
                Console.WriteLine("The sun is blasting on my face... I'm covering my eyes.");
            }
        }
    }
}
