using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;

        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }

        protected override void WriteMessage(string message, MessageType type)
        {
            using (System.IO.StreamWriter streamWriter =new System.IO.StreamWriter(filePath, true))
            {
                streamWriter.WriteLine(type + ": " + DateTime.Now);
                streamWriter.WriteLine(new string('=', message.Length));
                streamWriter.WriteLine(message);
                streamWriter.WriteLine(new string('=', message.Length) + "\n"); 
            }
        }

    }
}
