using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    interface ToDoTaskInterface
    {
        public void addRecord(Record addingRecord);
        public void deleteRecord(Record deletingRecord);
        public Record takeRecord(int takingRecord);
        public List<Record> takeRecordList();

    }
}
