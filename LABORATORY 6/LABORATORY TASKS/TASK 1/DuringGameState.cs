using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_6_TASKS
{
    internal class DuringGameState : GameState
    {
        public DuringGameState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("Opening the chat...");
            parentApp.ChangeState(new ChatState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Quitting to main menu...");
            parentApp.ChangeState(new MenuState(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("Opening the shop...");
            parentApp.ChangeState(new ShopState(parentApp));
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine("Doing nothing...");
        }
    }
}
