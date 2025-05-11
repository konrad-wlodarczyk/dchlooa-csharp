using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSimulator
{
    class MoveEast : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going east...");

            if(currentTime > 6 && currentTime < 9)
            {
                Console.WriteLine("The sun is blasting on my face... I'm covering my eyes.");
            }
        }
    }
}
