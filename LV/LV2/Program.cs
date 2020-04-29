using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            int numberOfObjects = 20;
            for (int i=0;i<numberOfObjects; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            diceRoller.rollingPrint(diceRoller.GetRollingResults());
        }
    }
}
