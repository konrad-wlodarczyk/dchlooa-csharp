using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    // invoker class
    class SmartHomeScheduler
    {
        public Dictionary<int, ISmartHomeExecutable> Commands { get; set; }
        public void Run()
        {
            for (int i = 0; i < 24; i++)
            {
                if(Commands.ContainsKey(i))
                {
                    Console.WriteLine(i + ":00");
                    Commands[i].Execute();
                }
            }
        }

        public SmartHomeScheduler()
        {
            Commands = new Dictionary<int, ISmartHomeExecutable>();
        }
    }
}
