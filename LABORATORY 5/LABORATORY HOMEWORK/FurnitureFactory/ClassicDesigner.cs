using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ClassicDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            if (priceLimit >= 500) return new ClassicDesk(priceLimit, "White");
            return null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            if (priceLimit >= 1000) return new ClassicWardrobe(priceLimit, "White");
            return null;
        }
    }
}
