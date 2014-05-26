using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterview.App.Tasks
{
    public static class PopularCharInString
    {
        //Task: 
        /*
         * Find the most popular character in a string
         */
        public static char MostPopular(string input)
        {
            if (input.Length <2)
                throw new ArgumentException("Your input must have more than one character");

            var results = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (character == ' ')
                    continue;

                if (results.ContainsKey(character))
                {
                    results[character]++;
                }
                else
                {
                    results.Add(character, 1);
                }
            }

            var mostPopular = ' ';
            var occurrences = 1;
            foreach (var entry in results)
            {
                if (entry.Value > occurrences)
                {
                    mostPopular = entry.Key;
                    occurrences = entry.Value;
                }
            }

            return mostPopular;
        }

        public static char LinqMostPopular(string input)
        {
            return input.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }
    }
}