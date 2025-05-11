using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_6_TASKS
{
    internal class ChatState : GameState
    {
        public ChatState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("Closing the chat...");
            parentApp.ChangeState(new DuringGameState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Closing the chat...");
            parentApp.ChangeState(new DuringGameState(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("Doing nothing...");
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine($"Message: {s}");
        }
    }
}
