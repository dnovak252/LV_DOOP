using System;
using System.Text.RegularExpressions;

namespace CheckIfPalindrome
{
    public class PalindromeCheck
    {
        private const int minimumStringToCheckLength = 1;

        public bool IsPalindrome(string stringToCheck)
        {
            int stringLength = stringToCheck.Length;
            if (stringLength < minimumStringToCheckLength)
            {
                throw new ArgumentException();
            }
            stringToCheck = stringToCheck.Replace(" ", String.Empty);
            string noSpecialCaractersString = Regex.Replace(stringToCheck, @"[^a-zA-Z]+", "");
            string finalStringToCheck = noSpecialCaractersString.ToLower();
            char[] tempArray = finalStringToCheck.ToCharArray();
            Array.Reverse(tempArray);
            string backwardsStringToCheck = new string(tempArray);
            if (finalStringToCheck == backwardsStringToCheck)
            {
               return true;
            }
            else
            {
               return false;
            }
        }
    }
}
