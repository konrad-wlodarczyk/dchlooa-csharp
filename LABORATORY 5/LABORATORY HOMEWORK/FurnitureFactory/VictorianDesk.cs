using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class VictorianDesk : Desk
    {
        public VictorianDesk(int price, string size) : base(price, "Dark Oak", "Mahogany wood", size, true) { }

        public override string Description() => $"Type of desk: Victorian, Color: {color}, Material: {material}, Size: {size}, Drawer: {hasDrawer}, Price: {price}";
    }
}
