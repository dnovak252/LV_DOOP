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

        private String getText() { return this.text; }
        private String getAuthor() { return this.author; }
        private int getImportance() { return this.importance; }
        private void setText(String text) { this.text = text; }
        private void setImportance(int importance) { this.importance = importance; }
    }
}
