using NUnit.Framework;
using System;

namespace CheckIfPalindrome.Test
{
    [TestFixture]
    public class PalindromeCheckTests
    {
        PalindromeCheck checkPalindrome = new PalindromeCheck();
        [Test]
        public void CheckIfPalindromeEmpty_WhenEmpty_ReturnsException()
        {
            string input = "";
            Assert.Throws<ArgumentException>(() => checkPalindrome.IsPalindrome(input));
        }
        [Test]
        public void CheckIfPalindrome_WhenPalindrome_ReturnsTrue()
        {
            bool expected = true;
            string input = "anavolimilovana";
            bool actual = checkPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckIfPalindrome_WhenNotPalindrome_ReturnsFalse()
        {
            bool expected = false;
            string input = "ovo nije palindrom";
            bool actual = checkPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckIfPalindrome_WhenPalindromeHasUppercases_ReturnsTrue()
        {
            bool expected = true;
            string input = "Ana voli Milovana";
            bool actual = checkPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckIfPalindrome_WhenPalindromeHasNumbers_ReturnsTrue()
        {
            bool expected = true;
            string input = "Ana voli Milovana123";
            bool actual = checkPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckIfPalindrome_WhenPalindromeHasSpecialCaracters_ReturnsTrue()
        {
            bool expected = true;
            string input = "!Ana voli Milovana*";
            bool actual = checkPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
