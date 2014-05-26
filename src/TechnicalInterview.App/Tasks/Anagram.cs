using System.Collections.Generic;

namespace TechnicalInterview.App.Tasks
{
    public static class Anagram
    {
        //Task:
        /*
         * Assuming we don't need to worry about "real" words,
         * create a method that returns if a second word is an anagram of the first

        /*Rules: 
         * can be non words
         * must have same character distribution
         * must be able to match cases
         * must be able to deal with characters
         */

        public static bool IsAnagram(string firstWord, string secondWord)
        {
            var firstResults = new Dictionary<char, int>();
            foreach (var character in firstWord)
            {
                if (firstResults.ContainsKey(character))
                {
                    firstResults[character]++;
                }
                else
                {
                    if (char.IsLetter(character))
                        firstResults.Add(char.ToLower(character), 1);
                }
            }

            var secondResults = new Dictionary<char, int>();
            foreach (var character in secondWord)
            {
                if (secondResults.ContainsKey(character))
                {
                    secondResults[character] ++;
                }
                else
                {
                    if (char.IsLetter(character))
                        secondResults.Add(char.ToLower(character), 1);
                }
            }

            foreach (var result in firstResults)
            {
                if (!secondResults.ContainsKey(result.Key))
                    return false;

                if (secondResults[result.Key] != result.Value)
                    return false;
            }

            return true;
        }
    }
}