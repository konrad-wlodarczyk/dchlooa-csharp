using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class RiverState : State
    {
        public override void FlowsInto()
        {
            Console.WriteLine("The river flows into the ocean...");
            this._context.TransitionTo(new OceanState());
        }

        public override void Evaporation()
        {
            Console.WriteLine("The river evaporates into the clouds...");
            this._context.TransitionTo(new CloudState());
        }

        public override void Drinking()
        {
            Console.WriteLine("The animal is drinking from the river...");
            this._context.TransitionTo(new AnimalState());
        }

        public override string Info()
        {
            return "The water droplet is in the river";
        }
    }
}
