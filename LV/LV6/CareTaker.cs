using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class CareTaker
    {
        public Memento PreviousState { get; set; }
        Stack<Memento> mementoStack = new Stack<Memento>();

        public void StackPush(Memento memento)
        {
            mementoStack.Push(memento);
        }
        public Memento StackPop()
        {
            return mementoStack.Pop();
        }
    }
}
