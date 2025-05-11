using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    abstract class InteriorDesigner
    {
        public abstract Desk ProduceDesk(int priceLimit);
        public abstract Wardrobe ProduceWardrobe(int priceLimit);
    }
}
