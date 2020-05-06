using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class DirectorClass
    {
        public void INFOConsoleNotification(IBuilder builder, string author)
        {
            builder.SetAuthor(author).SetTitle("Title").SetText("Test Text").SetTime(DateTime.Now).SetLevel(Category.INFO).SetColor(ConsoleColor.Green);
        }
        public void ALERTConsoleNotification(IBuilder builder, string author)
        {
            builder.SetAuthor(author).SetTitle("Title").SetText("Test Text").SetTime(DateTime.Now).SetLevel(Category.INFO).SetColor(ConsoleColor.Yellow);
        }
        public void ERRORConsoleNotification(IBuilder builder, string author)
        {
            builder.SetAuthor(author).SetTitle("Title").SetText("Test Text").SetTime(DateTime.Now).SetLevel(Category.INFO).SetColor(ConsoleColor.Red);
        }
    }
}
