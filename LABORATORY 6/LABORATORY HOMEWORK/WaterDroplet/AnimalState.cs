using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class AnimalState : State
    {
        public override void Excreting()
        {
            Console.WriteLine("The animal is excreting into the river...");
            this._context.TransitionTo(new RiverState());
        }

        public override void Respiration()
        {
            Console.WriteLine("The animal is respirating into the cloud...");
            this._context.TransitionTo(new CloudState());
        }

        public override string Info()
        {
            return "The water droplet is inside of an animal.";
        }
    }
}
