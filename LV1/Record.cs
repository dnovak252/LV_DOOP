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

        public String getText() { return this.text; }
        public String getAuthor() { return this.author; }
        public int getImportance() { return this.importance; }
        public void setText(String text) { this.text = text; }
        public void setImportance(int importance) { this.importance = importance; }
    }
}
