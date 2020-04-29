using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        //Zadatak 4
        //private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            //Zadatak 4
            //this.logger = logger;
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
        //Zadatak 3
        //public void rollingPrint(IList<int> resultForEachRoll)
        //{
        //    foreach (int number in resultForEachRoll)
        //        Console.WriteLine("Number rolled: " + number);
        //}
        //Zadatak 4
        //public void LogRollingResults()
        //{
        //    foreach(int result in this.resultForEachRoll)
        //    {
        //        Console.Write("Number rolled: ");
        //        logger.Log(result.ToString());
        //    }
        //}

        public string GetStringRepresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int result in this.resultForEachRoll)
            {
                stringBuilder.AppendFormat("\nNumber rolled: {0} ", result);
            }
            return stringBuilder.ToString();
        }
    }
}
