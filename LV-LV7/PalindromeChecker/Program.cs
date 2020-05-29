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
            string stringToCheck = "!Ana voli Milovana123";
            Console.WriteLine(stringToCheck+" je palindrom: "+palindrome.IsPalindrome(stringToCheck));
            string stringToCheck2 = "ovo nije palindrom";
            Console.WriteLine(stringToCheck2 + " je palindrom: "+palindrome.IsPalindrome(stringToCheck2));
        }
    }
}
