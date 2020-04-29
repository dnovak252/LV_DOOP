using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV1
{
    class ToDoListRecord : ToDoTaskInterface
    {
        private List<Record> allRecords = new List<Record>();
        public void addRecord(Record addingRecord)
        {
            if (!allRecords.Contains(addingRecord)) allRecords.Add(addingRecord);
        }

        public void deleteRecord(Record deletingRecord)
        {
            if (allRecords.Contains(deletingRecord)) allRecords.Remove(deletingRecord);
        }

        public Record takeRecord(int takingRecord)
        {
            return allRecords.ElementAt(takingRecord);
        }
        public void removeRecord(int takingIndex)
        {
            allRecords.RemoveAt(takingIndex);
        }
        public List<Record> takeRecordList()
        {
            return allRecords;
        }
    }
}
