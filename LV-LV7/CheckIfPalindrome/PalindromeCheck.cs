using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckIfPalindrome
{
    public class PalindromeCheck
    {
        public string IsPalindrome(string s)
        {
            s = s.Replace(" ", String.Empty);
            StringBuilder sb = new StringBuilder();
            string result = Regex.Replace(s, @"[^a-zA-Z]+", "");
            string LowerCaseString = result.ToLower();
            char[] array = LowerCaseString.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);
            return backwards;
        }
    }
}
