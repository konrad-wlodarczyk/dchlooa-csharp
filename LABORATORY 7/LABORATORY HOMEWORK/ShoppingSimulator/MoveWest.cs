using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSimulator
{
    class MoveWest : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going west...");

            if(currentTime > 15 && currentTime < 18)
            {
                Console.WriteLine("The sun is blasting on my face... I'm covering my eyes.");
            }
        }
    }
}
