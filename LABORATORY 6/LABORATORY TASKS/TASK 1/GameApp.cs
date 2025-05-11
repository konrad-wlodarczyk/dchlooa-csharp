using System;
using System.Collections.Generic;
using System.Text;

namespace LABORATORY_6_TASKS
{
    class GameApp
    {
        // tutaj przechowujemy obecny stan naszej aplikacji
        private GameState currentState; 

        // konstruktor
        public GameApp()
        {
            // zaczynamy od menu - jako argument konstruktora podajemy ten sam obiekt klasy GameApp, w ktorym obecnie jestesmy (slowo kluczowe this)
            currentState = new MenuState(this); 
        }

        // metoda pozwalajaca zmieniac stan na inny
        public void ChangeState(GameState newState) 
        {
            currentState = newState;
        }

        // ponizej znajduja sie metody dla uzytkownika
        public void EnterButton()
        {
            currentState.EnterButton();
        }
        public void EscapeButton()
        {
            currentState.EscapeButton();
        }
        public void TabButton()
        {
            currentState.TabButton();
        }
        public void KeyboardInput(string s) 
        { 
            currentState.KeyboardInput(s); 
        }

    }
}
