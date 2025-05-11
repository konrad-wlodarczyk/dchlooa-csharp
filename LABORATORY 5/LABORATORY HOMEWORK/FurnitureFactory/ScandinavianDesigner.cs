using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ScandinavianDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 1000) return new ScandinavianDesk(priceLimit, "White");
            return null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 2000) return new ScandinavianWardrobe(priceLimit, "Big", 2, true);
            return null;
        }
    }
}
