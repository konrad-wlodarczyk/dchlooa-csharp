using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    abstract class Fuel : ITransportable
    {
        protected double volume, weight;
        public abstract string Type { get; }
        protected double density {  get; set; }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * density;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / density;
            }
        }

        public Fuel()
        {
            this.volume = 0;
            this.weight = 0;
            this.density = 0;
        }

        public Fuel(double volume, double weight, double density)
        {
            this.volume = volume;
            this.weight = weight;
            this.density = density;
        }

        public new string GetType()
        {
            return Type;
        }

    }
}
