using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSimulator
{
    abstract class Move
    {
        public abstract void Execute(int currentTime);
    }
}
