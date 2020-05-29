using System;
using System.Text.RegularExpressions;

namespace CheckIfPalindrome
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string s)
        {
            int a = s.Length;
            if (a<1)
                throw new ArgumentException();
            s = s.Replace(" ", String.Empty);
            string noSpecialCaractersString = Regex.Replace(s, @"[^a-zA-Z]+", "");
            string  finalString= noSpecialCaractersString.ToLower();
            char[] array = finalString.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);
            if (finalString == backwards)
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
