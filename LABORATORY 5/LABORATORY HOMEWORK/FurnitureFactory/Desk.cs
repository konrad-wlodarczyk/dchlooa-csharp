using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    abstract class Desk
    {
        public int price { get; }
        public string color { get; }
        public string material { get; }
        public string size { get; }
        public bool hasDrawer { get; }

        public Desk(int price, string color, string material, string size, bool hasDrawer)
        {
            this.price = price;
            this.color = color;
            this.material = material;
            this.size = size;
            this.hasDrawer = hasDrawer;
        }

        public abstract string Description();
    }
}
