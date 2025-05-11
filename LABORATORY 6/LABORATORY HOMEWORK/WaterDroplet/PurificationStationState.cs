using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class PurificationStationState : State
    {
        public override void Purifying()
        {
            Console.WriteLine("The purification station is purifying the water into the river...");
            this._context.TransitionTo(new RiverState());
        }

        public override string Info()
        {
            return "The water droplet is in the purification station.";
        }
    }
}
