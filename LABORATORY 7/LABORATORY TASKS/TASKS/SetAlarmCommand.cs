using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class SetAlarmCommand : ISmartHomeExecutable
    {
        private SecurityAlarm alarm;
        private string password;

        public SetAlarmCommand(SecurityAlarm alarm, string password)
        {
            this.alarm = alarm;
            this.password = password;
        }

        public void Execute()
        {
            alarm.Lock(password);
        }
    }
}
