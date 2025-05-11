using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class StartWiFiCommand : ISmartHomeExecutable
    {
        private WiFi wifi;
        private string password;

        public StartWiFiCommand(WiFi wifi, string password)
        {
            this.wifi = wifi;
            this.password = password;
        }

        public void Execute()
        {
            wifi.IsCurrentlyOn = true;
            wifi.Login(password);
        }
    }
}
