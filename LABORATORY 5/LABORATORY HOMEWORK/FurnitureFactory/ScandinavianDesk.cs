using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ScandinavianDesk : Desk
    {
        public ScandinavianDesk(int price, string size) : base(price, "White Oak", "NordicPine", size, true) { }

        public override string Description() => $"Type of desk: Scandinavian, Color: {color}, Material: {material}, Size: {size}, Drawer: {hasDrawer}, Price: {price}";
    }
}
