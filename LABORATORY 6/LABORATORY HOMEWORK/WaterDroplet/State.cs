using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    abstract class State
    {
        public Context _context;

        public void SetContext(Context context) { this._context = context; }

        public virtual void Evaporation() => Console.WriteLine("Evaporation not allowed from this state.");
        public virtual void Percipitation(string direction) => Console.WriteLine("Precipitation not allowed from this state.");
        public virtual void Respiration() => Console.WriteLine("Respiration not allowed from this state.");
        public virtual void Drinking() => Console.WriteLine("Drinking not allowed from this state.");
        public virtual void FlowsInto() => Console.WriteLine("Flowing not allowed from this state.");
        public virtual void Excreting() => Console.WriteLine("Excreting not allowed from this state.");
        public virtual void Purifying() => Console.WriteLine("Purifying not allowed from this state.");


        public abstract string Info();
    }
}
