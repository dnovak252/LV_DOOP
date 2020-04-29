using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger(@"D:/LV_DOOP/LV/LV2/proba.txt");
            DiceRoller diceRoller = new DiceRoller(consoleLogger);
            int numberOfObjects = 20;
            for (int i=0;i<numberOfObjects; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            //diceRoller.rollingPrint(diceRoller.GetRollingResults());
            diceRoller.LogRollingResults();
        }
    }
}
