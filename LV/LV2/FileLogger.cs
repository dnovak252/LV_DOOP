using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LV2
{
    class FileLogger : ILogger
    {
        private string type;
        private string filePath= @"D:/LV_DOOP/LV/LV2/proba.txt";

        public FileLogger(string type, string filePath)
        {
            this.type = type;
            this.filePath = filePath;
        }
        public void Log(string message)
        {
            if(this.type.Equals("File"))
                using (StreamWriter writer=new StreamWriter(this.filePath))
                {
                  writer.WriteLine(message);
                }
        }
    }
}
