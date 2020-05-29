using NUnit.Framework;
using System;

namespace CheckIfPalindrome.Test
{
    [TestFixture]
    public class PalindromeCheckTests
    {
        PalindromeCheck palindromeCheck = new PalindromeCheck();

        [TestCase("")]
        public void CheckIfPalindromeEmpty_WhenEmpty_ReturnsException(string input)
        {
            Assert.Throws<ArgumentException>(() => palindromeCheck.IsPalindrome(input));
        }

        [TestCase("anavolimilovana")]
        [TestCase("tacocat")]
        public void CheckIfPalindrome_WhenPalindrome_ReturnsTrue(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase ("ovonijepalindrom")]
        [TestCase("thisisnotpalindrome")]
        public void CheckIfPalindrome_WhenNotPalindrome_ReturnsFalse(string input)
        {
            bool expected = false;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("AnaVoliMilovana")]
        [TestCase("TacoCat")]
        public void CheckIfPalindrome_WhenPalindromeHasUppercases_ReturnsTrue(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("AnaVoliMilovana123")]
        [TestCase("123TacoCat")]
        public void CheckIfPalindrome_WhenPalindromeHasNumbers_ReturnsTrue(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("*anavolimilovana!")]
        [TestCase("!tacocat*")]
        public void CheckIfPalindrome_WhenPalindromeHasSpecialCaracters_ReturnsTrue(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ana voli milovana")]
        [TestCase("taco cat taco cat")]
        public void CheckIfPalindrome_WhenPalindromeHasSpaces_ReturnsTrue(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("!Ana Voli 1Milovana")]
        [TestCase("!taco 123cat?")]
        public void CheckIfPalindrome_WhenPalindromeHasAll_ReturnsTrue(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
