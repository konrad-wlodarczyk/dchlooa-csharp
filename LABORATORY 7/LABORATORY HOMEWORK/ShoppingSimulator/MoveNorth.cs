using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSimulator
{
    class MoveNorth : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going north...");

            if(currentTime > 12 && currentTime < 15)
            {
                Console.WriteLine("The sun is blasting on my face... I'm covering my eyes.");
            }
        }
    }
}
