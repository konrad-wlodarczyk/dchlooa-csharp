using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class SetThermostatCommand : ISmartHomeExecutable
    {
        private Thermostat thermostat;
        private int temperature;

        public SetThermostatCommand(Thermostat thermostat, int temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }

        public void Execute()
        {
            thermostat.TargetTemperature = temperature;
        }
    }
}
