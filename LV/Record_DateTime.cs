using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Record_DateTime : Record
    {
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value;}
        }
        private DateTime time;
        public Record_DateTime(string text, string author, int importance) : base(text, author, importance)
        {
            time = DateTime.Now;
        }
        public override string ToString()
        {
            return base.ToString()+"\n\n\nCreation time: "+this.time;
        }
    }
}
