using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class ConsoleLogger : ILogger
    {
        private string type;
        public ConsoleLogger(string type)
        {
            this.type = type;
        }
        public void Log(string message)
        {
            if (this.type.Equals("Console"))
                Console.WriteLine(message);
        }
    }
}
