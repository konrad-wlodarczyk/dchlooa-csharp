using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class VictorianDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 5000) return new VictorianDesk(priceLimit, "White");
            return null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 12000) return new VictorianWardrobe(priceLimit, "Medium", 3);
            return null;
        }
    }
}
