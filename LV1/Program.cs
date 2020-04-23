using System;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Record record;
            Record record1= new Record("Text1", "Marko", 2);
            Record record2 = new Record("Text2", 4);
            Record record3 = new Record(3,"Ivo");
            Record record4 = new Record("Branko");

            Console.WriteLine(record1.Text + ", " + record1.Author + ", " + record1.Importance);
            Console.WriteLine(record2.Text + ", " + record2.Importance);
            Console.WriteLine(record3.Importance + ", " + record3.Author);
            Console.WriteLine(record4.Author);
        }
    }
}
