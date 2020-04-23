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

            Console.WriteLine(record1.getText() + ", " + record1.getAuthor() + ", " + record1.getImportance());
            Console.WriteLine(record2.getText() + ", " + record2.getImportance());
            Console.WriteLine(record3.getImportance() + ", " + record3.getAuthor());
        }
    }
}
