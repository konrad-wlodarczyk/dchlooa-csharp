using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class OceanState : State
    {
        public override void Evaporation()
        {
            Console.WriteLine("The ocean evaporates into the cloud...");
            this._context.TransitionTo(new CloudState());
        }

        public override string Info()
        {
            return "The water droplet is in the ocean.";
        }
    }
}
