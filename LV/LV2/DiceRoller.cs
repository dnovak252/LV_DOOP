using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = new ConsoleLogger("File");
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
        public void rollingPrint(IList<int> resultForEachRoll)
        {
            foreach(int number in resultForEachRoll)
            Console.WriteLine("Number rolled: " + number);
        }
        public void LogRollingResults()
        {
            foreach(int result in this.resultForEachRoll)
            {
                logger.Log(result.ToString());
            }
        }
    }
}
