using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LV3
{
    class FileLogger
    {
        private static FileLogger instance;
        private string filePath;
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public static FileLogger GetInstance(string filePath)
        {
            if (instance == null)
            {
                instance = new FileLogger(filePath);
            }
            return instance;
        }
        public void Log(string note)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath, true))
            {
                writer.WriteLine(note);
            }
        }
    }
}
