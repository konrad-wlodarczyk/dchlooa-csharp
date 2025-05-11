using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class WellState : State
    {
        public override void Drinking()
        {
            Console.WriteLine("The human is drinking from the well...");
            this._context.TransitionTo(new HumanState());
        }

        public override string Info()
        {
            return "The water droplet is inside of a well.";
        }
    }
}
