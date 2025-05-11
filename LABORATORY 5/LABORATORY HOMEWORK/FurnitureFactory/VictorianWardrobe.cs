using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class VictorianWardrobe : Wardrobe
    {
        public VictorianWardrobe(int price, string size, int numberOfDoors) : base(price, "Dark Oak", "Mahogany wood", size, numberOfDoors, false) { }

        public override string Description() => $"Type of wardrobe: Victorian, Color: {color}, Material: {material} Size: {size}, Number of doors: {numberOfDoors}, Mirror: {hasMirror}, Price: {price}";
    }
}
