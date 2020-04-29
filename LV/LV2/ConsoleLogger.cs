using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
                Console.WriteLine(message);
        }
    }
}
