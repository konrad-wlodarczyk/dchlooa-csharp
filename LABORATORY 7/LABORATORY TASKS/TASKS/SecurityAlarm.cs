using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    // receiver class
    class SecurityAlarm
    {
        private string password;
        public bool Enterable { get; private set; }
        public void Lock(string pwd)
        {
            if (pwd == password)
            {
                Enterable = false;
                Console.WriteLine("Security alarm is now active.");
            }
        }
        public void Unlock(string pwd)
        {
            if (pwd == password)
            {
                Enterable = true;
            }
        }
        public SecurityAlarm(string pwd)
        {
            password = pwd;
            Enterable = false;
        }

    }
}
