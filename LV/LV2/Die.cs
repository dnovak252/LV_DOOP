using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;

        public Die(int numberOfSides, Random randomNumbers)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomNumbers;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
