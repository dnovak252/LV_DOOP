using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    public enum Importance{
        lowest, low, medium, high, highest
    }
    class Record
    {
        private String text;
        private String author;
        private int importance;
        
        public string Text {
            get { return this.text; }
            set { this.text = value; }
        }
        public string Author{
            get { return this.author; }
            private set { this.author = string.Empty; }
        }
        public int Importance{
            get { return this.importance; }
            set { this.importance = value; }
        }

        public Record() { }            
        public Record (string author)
        {
            this.author = author;
        }
        public Record(string text, string author, int importance)
        {
            this.text = text;
            this.author = author;
            this.importance = importance;
        }
       
       
        public override string ToString() { 
           return this.text + ", " + this.author + ", " + this.importance; }
    }
}
