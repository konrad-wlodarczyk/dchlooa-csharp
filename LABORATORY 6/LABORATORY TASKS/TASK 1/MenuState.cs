using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_6_TASKS
{
    internal class MenuState : GameState
    {
        public MenuState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("Starting the game...");
            parentApp.ChangeState(new DuringGameState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Doing nothing...");
        }

        public override void TabButton()
        {
            Console.WriteLine("Doing nothing...");
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine("Doing nothing...");
        }
    }
}
