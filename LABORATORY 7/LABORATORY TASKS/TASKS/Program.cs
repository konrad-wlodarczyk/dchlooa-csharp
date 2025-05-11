using System;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {
            // urzadzenia w domu
            WiFi myWiFi = new WiFi("routerXYZ", "bezpieczneHaslo1");
            Thermostat myThermostat = new Thermostat();
            SecurityAlarm myAlarm = new SecurityAlarm("bezpieczneHaslo2");



            // wersja bez wzorca polecenie - wracamy do domu o 17
            // te komendy trzeba bedzie powtarzac kazdego dnia
            /*
            myWiFi.IsCurrentlyOn = true; 
            myWiFi.Login("bezpieczneHaslo1"); // trzeba wywolac metody z odpowiednimi parametrami - kazda klasa ktora chce uzyc WiFi musi znac do niego hasło
            myThermostat.TargetTemperature = 22; // niestety termostat potrzebuje troche czasu - wlasciwa temperature osiagniemy dopiero za godzine
            // teraz cos robie...
            myAlarm.Lock("bezpieczneHaslo2"); // o 23 ide spac i musze pamietac o wlaczeniu alarmu
            */


            // wersja z wzorcem polecenie - rowniez wracamy do domu o 17
            // zdefiniujmy czynnosci do automatycznego wykonywania codziennie
            
            SmartHomeScheduler controller = new SmartHomeScheduler();
            StartWiFiCommand command1 = new StartWiFiCommand(myWiFi, "bezpieczneHaslo1"); // polecenie samo przechowa swoje parametry do przyszlego uzycia - klasa ktora bedzie chciała uzyc WiFi nie musi juz znac do niego hasła, wystarczy ze uzyje gotowego obiektu typu polecenie
            SetThermostatCommand command2 = new SetThermostatCommand(myThermostat, 22);
            SetAlarmCommand command3 = new SetAlarmCommand(myAlarm, "bezpieczneHaslo2");
            controller.Commands.Add(16, command2); // niech termostat uruchomi sie automatycznie juz o 16:00
            controller.Commands.Add(17, command1); // wifi wystarczy uruchomic o 17:00
            controller.Commands.Add(23, command3); // o 23:00 alarm wlaczy sie sam
            controller.Run();
            


            // test adaptera
            WiFi2 oldRouter = new WiFi2("stareHaslo7"); // stary router nie potrafi ustawic stalej nazwy sieci
            WifiAdapter myAdapter = new WifiAdapter(oldRouter, "routerXYZ"); // ale nasz adapter bedzie potrafil
            // gotowego adaptera mozna uzywac jak standardowego routera typu WiFi
            myAdapter.IsCurrentlyOn = true;
            myAdapter.Login("stareHaslo7");
            StartWiFiCommand testCommand = new StartWiFiCommand(myAdapter, "stareHaslo7");
            
        }
    }
}
