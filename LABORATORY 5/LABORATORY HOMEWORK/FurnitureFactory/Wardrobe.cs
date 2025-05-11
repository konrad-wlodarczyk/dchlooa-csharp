using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    abstract class Wardrobe
    {
        public int price { get; }
        public string color { get; }
        public string material { get; }
        public string size { get; }
        public int numberOfDoors {  get; }
        public bool hasMirror { get; }

        public Wardrobe(int price, string color, string material, string size, int numberOfDoors, bool hasMirror)
        {
            this.price = price;
            this.color = color;
            this.material = material;
            this.size = size;
            this.numberOfDoors = numberOfDoors;
            this.hasMirror = hasMirror;
        }

        public abstract string Description();
    }
}
