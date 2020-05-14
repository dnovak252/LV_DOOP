using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class EmailValidator
    {
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return hasAtSign(candidate) && emailEnding(candidate);

        }

        private bool hasAtSign(string candidate)
        {
            if (candidate.Contains("@")) return true;
            return false;
        }
        private bool emailEnding(string candidate)
        {
            string endsCom = ".com";
            string endsHr = ".hr";
            if (candidate.EndsWith(endsCom) || candidate.EndsWith(endsHr)) return true;
            return false;
        }

    }
}
