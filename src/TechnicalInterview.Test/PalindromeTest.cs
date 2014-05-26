using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class PalindromeTest
    {
        public static string[] palindromes = { "racecar", "testset", "level", "civic", "ana" };
        public static string[] words = { "lucas", "moffitt", "wordymcwordster" };

        [TestMethod]
        public void IsPalindromeThrowsArgumentExceptionWithEmptyInput()
        {
            try
            {
                var palindrome = Palindrome.IsPalindrome("");
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void IsPalindromeThrowsArgumentExceptionWithShortInput()
        {
            try
            {
                var palindrome = Palindrome.IsPalindrome("c");
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void IsPalindromeReturnsTrueForPalindrome()
        {
            foreach (var word in palindromes)
            {
                Assert.IsTrue(Palindrome.IsPalindrome(word));
            }
        }

        [TestMethod]
        public void IsPalindromeReturnsFalseForNormalWords()
        {
            foreach (var word in words)
            {
                Assert.IsFalse(Palindrome.IsPalindrome(word));
            }
        }

        [TestMethod]
        public void LinqIsPalindromeReturnsTrueForPalindrome()
        {
            foreach (var word in palindromes)
            {
                Assert.IsTrue(Palindrome.LinqIsPalindrome(word));
            }
        }

        [TestMethod]
        public void LinqIsPalindromeReturnsFalseForNormalWords()
        {
            foreach (var word in words)
            {
                Assert.IsFalse(Palindrome.LinqIsPalindrome(word));
            }
        }
    }
}