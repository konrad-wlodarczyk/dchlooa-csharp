using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class CloudState : State
    {
        public override void Percipitation(string direction)
        {
            switch (direction.ToLower())
            {
                case "river":
                    Console.WriteLine("Cloud precipitates to the river...");
                    this._context.TransitionTo(new RiverState());
                    break;
                case "plant":
                    Console.WriteLine("Cloud precipitates to a plant...");
                    this._context.TransitionTo(new PlantState());
                    break;
                case "well":
                    Console.WriteLine("Cloud precipitates to a well...");
                    this._context.TransitionTo(new WellState());
                    break;
                default:
                    Console.WriteLine("Unknown precipitation target.");
                    break;
            }
        }

        public override string Info()
        {
            return "The water droplet is in the cloud.";
        }
    }
}
