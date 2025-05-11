using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    interface IVisitPort : ITransportable
    {
        // some ITransportable items will be refilled or disposed during each port visit
        // examples: food (refill), oxygen (refill), fuel (refill), waste (dispose)
        // each IVisitPort item has to know its refillment/disposal cost 
        double VisitPort(); // this method should update volume & weight, then return total cost
    }
}
