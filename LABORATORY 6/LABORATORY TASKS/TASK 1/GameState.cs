using System;
using System.Collections.Generic;
using System.Text;

namespace LABORATORY_6_TASKS
{
    abstract class GameState
    {
        // kazdy stan musi wiedziec kto go uzywa, na wypadek gdyby potrzebowal wywolac metode ChangeState 
        protected GameApp parentApp;

        // dlatego bedziemy podawali obiekt typu GameApp w konstruktorze
        public GameState(GameApp app) 
        {
            parentApp = app;
        }

        // ponizej znajduja sie metody, ktore kazdy stan bedzie musial zaimplementowac w inny sposob
        public abstract void EnterButton();
        public abstract void EscapeButton();
        public abstract void TabButton();
        public abstract void KeyboardInput(string s);

    }
}
