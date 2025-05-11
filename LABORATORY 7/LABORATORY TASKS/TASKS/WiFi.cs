using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    // receiver class
    class WiFi
    {
        protected string network, password;
        protected bool isCurrentlyOn;
        public virtual bool IsCurrentlyOn 
        {
            get { return isCurrentlyOn; }
            set
            {
                if (value == true) { Console.WriteLine("WiFi turned on."); }
                else { Console.WriteLine("WiFi turned off."); }
                isCurrentlyOn = value;
            }
        }
        public virtual void Login(string pwd)
        {
            if (IsCurrentlyOn == false) return;
            if (password != pwd) Console.WriteLine("Wrong password!");
            else
            {
                Console.WriteLine("Attempting to log to " + network + "...");
                Console.Write("Password: ");
                for (int i = 0; i < password.Length; i++) Console.Write("*");
                Console.WriteLine("\nLogin successful!");
            }
        }
        public WiFi(string net, string pwd)
        {
            network = net;
            password = pwd;
            isCurrentlyOn = false;
        }
    }
}
