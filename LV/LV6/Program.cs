using System;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1 = new Note("First Note.", "I am note number one.");
            Note note2 = new Note("Second Note", "I am note number two.");
            Note note3 = new Note("Third Note", "I am note number three.");
            Notebook notebook = new Notebook();
            notebook.AddNote(note1);
            notebook.AddNote(note2);
            notebook.AddNote(note3);
            IAbstractIterator iterator = notebook.GetIterator();
            for (int i = 0; i < notebook.Count; i++)
            {
                iterator.Current.Show();  
                iterator.Next();
            }
        }
    }
}
