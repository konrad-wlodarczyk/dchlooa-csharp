using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDroplet
{
    class Context
    {
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: transition to: {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        public void Evaporation() => this._state.Evaporation();
        public void Percipitation(string direction) => this._state.Percipitation(direction);
        public void Respiration() => this._state.Respiration();
        public void Drinking() => this._state.Drinking();
        public void FlowsInto() => this._state.FlowsInto();
        public void Excreting() => this._state.Excreting();
        public void Purifying() => this._state.Purifying();

        public string GetInfo()
        {
            return this._state.Info();
        }
    }
}
