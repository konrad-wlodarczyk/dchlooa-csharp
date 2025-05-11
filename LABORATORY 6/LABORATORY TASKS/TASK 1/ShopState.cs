using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_6_TASKS
{
    internal class ShopState : GameState
    {
        public ShopState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("Opening the chat...");
            parentApp.ChangeState(new MenuState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Closing the shop...");
            parentApp.ChangeState(new DuringGameState(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("Doing nothing...");
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine($"Item: {s}");
        }
    }
}
