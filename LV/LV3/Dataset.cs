using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Dataset : Prototype
    {
        private List<List<string>> data; 
        
        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader= new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
                new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            Dataset deepCopyDataset = new Dataset();
            var result = new List<List<string>>();
            foreach (List<string> innerList in this.data)
            {
                var innerResult = new List<string>();
                foreach (string item in innerList)
                {
                    var clone = (string)item.Clone();
                    innerResult.Add(clone);
                }
                result.Add(innerResult);
            }
            deepCopyDataset.data = result;
            return deepCopyDataset;
        }
        public string PrintDataList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (List<string> items in this.data)
            {
                foreach (var item in items)
                {
                    stringBuilder.Append(item).Append(" ");
                }

            }
            return stringBuilder.ToString();
        }

    }
}
