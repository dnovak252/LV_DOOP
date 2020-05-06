﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    public enum Category { ERROR, ALERT, INFO }
    class ConsoleNotification : Prototype
    {

        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public ConsoleNotification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
        
        //Mislim da ima razlike jer je deep clone pohranjen u novom objektu i nije ovisan o pocetnom objektu
    }
}
