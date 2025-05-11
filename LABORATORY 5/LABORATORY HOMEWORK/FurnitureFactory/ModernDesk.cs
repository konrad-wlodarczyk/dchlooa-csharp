using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    class ModernDesk : Desk
    {
        public ModernDesk(int price, string size) : base(price, "White", "Plywood", size, true) { }

        public override string Description() => $"Type of desk: Modern, Color: {color}, Material: {material}, Size: {size}, Drawer: {hasDrawer}, Price: {price}";
    }
}
