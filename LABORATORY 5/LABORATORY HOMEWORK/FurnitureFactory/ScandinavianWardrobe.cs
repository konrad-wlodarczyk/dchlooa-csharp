using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ScandinavianWardrobe : Wardrobe
    {
        public ScandinavianWardrobe(int price, string size, int numberOfDoors, bool hasMirror) : base(price, "White Oak", "Nordic Pine", size, numberOfDoors, hasMirror) { }

        public override string Description() => $"Type of wardrobe: Scandinavian, Color: {color}, Material: {material}, Size: {size}, Number of doors: {numberOfDoors}, Mirror: {hasMirror}, Price: {price}";
    }
}
