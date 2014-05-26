using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterview.App.Tasks
{
    public static class MissingNumbers
    {
        //Task: 
        /*
         * If you're given the numbers from 1 to 10000000, and I take a number out at 
         * random 2824 for example, how do you find which number is missing?
        */

        //Solution: 
        /*
         * If you add each number from 1 - 10000000 together, and then do the same
         * with your given numbers, the result will be your given sum from the possible.
         */

        //Assumptions: only one number is missing from the collection.
        public static int FindMissing(IEnumerable<int> expected, IEnumerable<int> input)
        {
            var totalOutput = 0;
            foreach (var number in expected)
            {
                totalOutput = totalOutput + number;
            }

            var totalInput = 0;
            foreach (var number in input)
            {
                totalInput = totalInput + number;
            }

            return totalOutput - totalInput;
        }
        
        // Linq Solution:
        /*
         * returns the items in the expected that don't appear in the input.
         * Note: this assumes only one is missing and only returns the first.
         */
        public static int LinqFindMissing(IEnumerable<int> expected, IEnumerable<int> input)
        {
            return expected.Except(input).FirstOrDefault();
        }
    }
}