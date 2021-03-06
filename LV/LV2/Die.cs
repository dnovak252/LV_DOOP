﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;

        public int NumberOfSides
        {
           get { return this.numberOfSides; }
        }
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
