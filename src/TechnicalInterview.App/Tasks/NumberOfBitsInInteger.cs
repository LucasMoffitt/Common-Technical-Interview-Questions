namespace TechnicalInterview.App.Tasks
{
    public class NumberOfBitsInInteger
    {
        //Task:
        /*
         * Given an unsigned integer, return the ammount of "on" bits

        /*Rules: 
         * Use a bitwise operator
         */
        public static int CountBits(uint input)
        {
            var count = 0;
            while (input > 0)
            {
                //This is here so you can see it during debug
                //var binary = Convert.ToString(input, 2);
                
                input = input & (input - 1);
                count++;
            }

            return count;
        }
    }
}