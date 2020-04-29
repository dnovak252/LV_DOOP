using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    interface IDiceRoller
    {
        void InsertDie();
        void RemoveAllDice();
        void RollAllDice();
    }
}
