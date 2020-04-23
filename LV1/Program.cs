using System;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Record record1= new Record("Text1", "Marko", 2);
            Record record2 = new Record("Text2",string.Empty , 4);
            Record record3 = new Record(3,"Ivo");
            Record record4 = new Record("Branko");
            
            Console.WriteLine(record1.ToString());
            Console.WriteLine(record2.ToString());
            record3.Text="Text3";
            Console.WriteLine(record3.ToString());
            record4.Text = "Text4";
            record4.Importance = 5;
            Console.WriteLine(record4.ToString());

            Record_DateTime myRecordTime =new Record_DateTime("Text", "Author", 2);
            DateTime currentTime = new DateTime(2000,01,01,20,05,55);
            myRecordTime.Time = currentTime;
            Console.WriteLine("\n"+myRecordTime.ToString());
        }
    }
}
