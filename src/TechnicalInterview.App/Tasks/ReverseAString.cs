using System.Linq;

namespace TechnicalInterview.App.Tasks
{
    public static class ReverseAString
    {
        public static string ReverseString(string input)
        {
            var charArray = new char[input.Length];
            var inputLength = input.Length - 1;

            for (int index = 0; index <= inputLength; index++)
                charArray[index] = input[inputLength - index];

            return new string(charArray);
        }

        public static string LinqReverseString(string input)
        {
            return input.Reverse().ToString();
        }
    }
}
