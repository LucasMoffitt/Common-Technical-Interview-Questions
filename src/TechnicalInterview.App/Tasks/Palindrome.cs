using System;
using System.Linq;

namespace TechnicalInterview.App.Tasks
{
    public static class Palindrome
    {
        //Task: 
        /*
         * Establish if a given word is a palindrome, ensure to include basic error checking
         */
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("You must not have an empty string as input");

            if (word.Count() < 2)
                throw new ArgumentException("Your input string needs to be longer than one character");

            var palindrome = true;

            for (var index = 0; index < word.Length / 2 + 1; index++)
            {
                if (word[index] != word[word.Length - index - 1])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }

        public static bool LinqIsPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }
}