using System;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zadatak
            //Note note1 = new Note("First Note.", "I am note number one.");
            //Note note2 = new Note("Second Note", "I am note number two.");
            //Note note3 = new Note("Third Note", "I am note number three.");
            //Notebook notebook = new Notebook();
            //notebook.AddNote(note1);
            //notebook.AddNote(note2);
            //notebook.AddNote(note3);
            //IAbstractIterator iterator = notebook.GetIterator();
            //for (int i = 0; i < notebook.Count; i++)
            //{
            //    iterator.Current.Show();  
            //    iterator.Next();
            //}

            Product product1 = new Product("Milk", 1.8);
            Product product2 = new Product("Bread", 1);
            Product product3 = new Product("Eggs", 2.2);
            Box box = new Box();
            box.AddProduct(product1);
            box.AddProduct(product2);
            box.AddProduct(product3);
            IAbstractIteratorTask2 iteratorTask2 = box.GetIterator();
            for (int i = 0; i <box.Count; i++)
            {
                Console.WriteLine(iteratorTask2.Current.ToString());
                iteratorTask2.Next();
            }
        }
    }
}
