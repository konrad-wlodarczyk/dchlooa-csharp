using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ClassicDesk : Desk
    {
        public ClassicDesk(int price, string color) : base(price, color, "Classic wood", "Medium", false) { }

        public override string Description() => $"Type of desk: Classic, Color: {color}, Material: {material}, Size: {size}, Drawer: {hasDrawer}, Price: {price}";

    }
}
