using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ModernDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 1000) return new ModernDesk(priceLimit, "White");
            return null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 2000) return new ModernWardrobe(priceLimit, "Small", 2, true);
            return null;
        }
    }
}
