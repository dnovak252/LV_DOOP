using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class PeopleGroupNote : Note
    {
        public List<string> groupList;
        public PeopleGroupNote(string message, ITheme theme) : base(message, theme)
        {
            this.groupList = new List<string>();
        }
        public void printGroup()
        {
            foreach (string name in groupList)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("People in this group: ");
            this.printGroup();
            string framedListOfPeople = this.GetFramedMessage();
            Console.WriteLine(framedListOfPeople);
            Console.ResetColor();
        }
        public void AddinGroup(string name)
        {
            groupList.Add(name);
        }
        public void RemovefromGroup(string name)
        {
            groupList.Remove(name);
        }
    }
}
