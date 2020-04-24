using System;
using System.Net;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Record record1 = new Record("Text1", "Marko", 2);
            Record record2 = new Record("Text2", string.Empty, 4);
            Record record3 = new Record("Branko");

            Console.WriteLine(record1.ToString());
            Console.WriteLine(record2.ToString());
            record3.Text = "Text3";
            Console.WriteLine(record3.ToString());
            record3.Text = "Text4";
            record3.Importance = 4;
            Console.WriteLine(record3.ToString());

            ToDoListRecord listrecord = new ToDoListRecord();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nInput text: ");
                string text = Console.ReadLine();
                Console.WriteLine("Input author: ");
                string author = Console.ReadLine();
                Console.WriteLine("Input importance:");
                int importance = Convert.ToInt32(Console.ReadLine());

                listrecord.addRecord(new Record_DateTime(text, author, importance));
            }

            foreach (Record record in listrecord.takeRecordList())
            {
                Console.WriteLine(record.ToString());
            }
            Console.WriteLine("______________________________________________________________________________________");
            for (int i = 0; i < 3; i++)
            {
                if (listrecord.takeRecord(i).Importance == 4)
                {
                    listrecord.removeRecord(i);
                }
            }
            foreach (Record record in listrecord.takeRecordList())
            {
                Console.WriteLine(record.ToString());
            }

        }
    }
}
