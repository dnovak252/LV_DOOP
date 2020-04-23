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
        
        public string getText() { return this.text; }
        public string getAuthor() { return this.author; }
        public int getImportance() { return this.importance; }
        public void setText(string text) { this.text = text; }
        public void setImportance(int importance) { this.importance = importance; }

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
