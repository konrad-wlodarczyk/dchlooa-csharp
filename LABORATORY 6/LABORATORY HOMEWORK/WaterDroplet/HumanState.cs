using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class HumanState : State
    {
        public override void Excreting()
        {
            Console.WriteLine("The human is excreting into the purification station...");
            this._context.TransitionTo(new PurificationStationState());
        }

        public override void Respiration()
        {
            Console.WriteLine("The human is respirating into the cloud...");
            this._context.TransitionTo(new CloudState());
        }

        public override string Info()
        {
            return "The water droplet is inside of a human";
        }
    }
}
