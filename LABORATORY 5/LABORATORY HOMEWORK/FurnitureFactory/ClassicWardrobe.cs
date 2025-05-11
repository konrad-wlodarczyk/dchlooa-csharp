using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ClassicWardrobe : Wardrobe
    {
        public ClassicWardrobe(int price, string color) : base(price, color, "Classic wood", "Moderate", 2, true) { }

        public override string Description() => $"Type of wardrobe: Classic, Color: {color}, Material: {material}, Size: {size}, Number of doors: {numberOfDoors}, Mirror: {hasMirror}, Price: {price}.";
    }
}
