using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ModernWardrobe : Wardrobe
    {
        public ModernWardrobe(int price, string size, int numberOfDoors, bool hasMirror) : base(price, "Dark Gloss", "Plywood", size, numberOfDoors, hasMirror) { }

        public override string Description() => $"Type of wardrobe: Modern, Color: {color}, Material: {material}, Size: {size}, Number of doors: {numberOfDoors}, Mirror: {hasMirror}, Price: {price}";
    }
}
