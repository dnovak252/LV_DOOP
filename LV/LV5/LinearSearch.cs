using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class LinearSearch:ISearchStrategy
    {
        public void Search(double[] array, double searchNumber)
        {
            bool temp = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchNumber)
                {
                    temp = true;
                    Console.WriteLine("Number " + searchNumber + " was found in array on " + i + " position");

                }
            }
            if (!temp)
            {
                Console.WriteLine(searchNumber + " was not found in array.");
            }
        }
    }
}
