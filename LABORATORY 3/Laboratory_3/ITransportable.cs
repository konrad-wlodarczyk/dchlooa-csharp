using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    interface ITransportable
    {
        // anything we can transport is ITransportable
        // examples: people, food, waste, fuel, equipment
        // each transportable item has to know its volume in m^3 and weight in tonnes
        // important: if you change volume, weight should update automatically and vice versa
        // you can use any numbers you want - don't worry about being realistic
		// see Equipment.cs for an example implementation
        double Volume { get; set; } 
        double Weight { get; set; }
    }
}
