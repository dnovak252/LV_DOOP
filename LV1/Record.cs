using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
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
        }
        public int Importance{
            get { return this.importance; }
            set { this.importance = value; }
        }

        public Record() { }            
        public Record (string author){
            this.author = author;
        }
        public Record(string text, string author, int importance){
            this.text = text;
            this.author = author;
            this.importance = importance;
        }
        public Record(string text, int importance){
            this.text = text;
            this.importance = importance;
        }
        public Record(int importance, string author){
            this.importance = importance;
            this.author = author;
        }
    }
}
