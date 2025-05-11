using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_6_TASKS
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Loading the game...");
            Console.WriteLine("- - - - SACRILEGE - - - -");

            GameApp gameApp = new GameApp();
       
            gameApp.EnterButton(); //STARTING THE GAME
            gameApp.EnterButton(); //OPENING CHAT
            gameApp.KeyboardInput("siema przywoływaczu!"); //SENDING MESSAGE
            gameApp.EscapeButton(); //CLOSING THE CHAT
            gameApp.TabButton(); //OPENING THE STORE
            gameApp.KeyboardInput("Buława"); //FINDING ITEM
            gameApp.EnterButton(); //OPENING THE CHAT FROM THE STORE POSITION
            gameApp.EnterButton(); //CLOSING THE CHAT
            gameApp.KeyboardInput("nothing"); //DOING NOTHING
            gameApp.EscapeButton(); //GOING BACK TO MAIN MENU
        }
    }
}
