using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class PlantState : State
    {
        public override void Respiration()
        {
            Console.WriteLine("The plant respirates to the cloud...");
            this._context.TransitionTo(new CloudState());
        }

        public override string Info()
        {
            return "The water droplet is in the plant.";
        }
    }
}
