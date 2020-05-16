using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class Task4Theme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }

    }
}

