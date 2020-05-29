using CheckIfPalindrome;
using System;
using System.Linq.Expressions;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeCheck palindrome = new PalindromeCheck();
            string s = "Ana voli Milovana";
            Console.Write(palindrome.IsPalindrome(s));
        }
    }
}
