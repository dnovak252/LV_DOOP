using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class DataConsolePrinter
    {
        public static void dataPrint(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();
            if (data == null)
            {
                Console.WriteLine("Error");
                return;
            }
            else 
            {
                foreach (List<string> list in data)
                {

                    foreach (string s in list)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}