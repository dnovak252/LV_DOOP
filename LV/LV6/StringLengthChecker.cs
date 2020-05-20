using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class StringLengthChecker : StringChecker
    {
        private int minimunStringLength = 7;
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length >= minimunStringLength) return true;
            return false;
        }
    }
}
