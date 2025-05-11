using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    abstract class Human : ITransportable
    {
        protected double volume, weight;
        public Human() {}

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; 
            }
        }

    }
}
