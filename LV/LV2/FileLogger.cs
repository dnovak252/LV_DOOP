using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LV2
{
    class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(string message)
        {
               using (StreamWriter writer=new StreamWriter(this.filePath))
                {
                  writer.WriteLine(message);
                }
        }
    }
}
