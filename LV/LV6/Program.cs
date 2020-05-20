﻿using System;

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

            //2. zadatak
            //Product product1 = new Product("Milk", 1.8);
            //Product product2 = new Product("Bread", 1);
            //Product product3 = new Product("Eggs", 2.2);
            //Box box = new Box();
            //box.AddProduct(product1);
            //box.AddProduct(product2);
            //box.AddProduct(product3);
            //IAbstractIteratorTask2 iteratorTask2 = box.GetIterator();
            //for (int i = 0; i <box.Count; i++)
            //{
            //    Console.WriteLine(iteratorTask2.Current.ToString());
            //    iteratorTask2.Next();
            //}

            //3.zadatak
            var dateTime = new DateTime(2020, 12, 21, 16, 0, 0);
            var dateTime2 = new DateTime(2020, 12, 21, 12, 0, 0);
            ToDoItem item1 = new ToDoItem("Item no.1", "Clean room", dateTime);
            Console.WriteLine(item1.ToString());
            CareTaker careTaker = new CareTaker();
            careTaker.StackPush(item1.StoreState());
            item1.Rename("Item no.1 - Update");
            item1.ChangeTask("Wash the dishes");
            item1.ChangeTimeDue(dateTime2);
            Console.WriteLine(item1.ToString());
            item1.RestoreState(careTaker.StackPop());
            Console.WriteLine(item1.ToString());
        }
    }
}
