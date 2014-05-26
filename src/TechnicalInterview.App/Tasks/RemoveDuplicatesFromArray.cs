using System;
using System.Linq;

namespace TechnicalInterview.App.Tasks
{
    //Task:
    /*
     * Given an array of integers, check and remove any duplicates

    /*Rules: 
     * Ensure you resize the array
     */
    public static class RemoveDuplicatesFromArray
    {
        public static int[] RemoveDuplicateInts(int[] input)
        {
            var results = new int[input.Length];
            var count = 0;
            foreach (var item in input)
            {
                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (item == results[i])
                        found = true;
                }
             
                if (!found)
                {
                    results[count] = item;
                    count++;
                }
            }

            Array.Resize(ref results, count);
            return results;
        }

        public static int[] LinqRemoveDuplicates(int[] input)
        {
            return input.Distinct().ToArray();
        }
    }
}
