namespace TechnicalInterview.App.Tasks
{
    //Task:
    /*
     * Given an array of integers, and a stand alone integer,
     * Find if any of the integers in the array add together to equal the stand alone
     */
    public static class FindNumbersThatEqual
    {
        public static int[] FindNumbersFromInputThatEqualGivenInt(int[] input, int match)
        {
            for (var input1 = 0; input1 < input.Length; input1++)
            {
                for (var input2 = input1; input2 < input.Length; input2++)
                {
                    if (input[input1] + input[input2] == match)
                        return new[] {input[input1], input[input2]};
                }
            }
            return null;
        }
    }
}
