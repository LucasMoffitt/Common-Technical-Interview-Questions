namespace TechnicalInterview.App.Tasks
{
    //Task:
    /*
     * Write an algorithm to reverse an integer,

    /*Rules: 
     * No extension / helper / linq methods
     */
    public static class ReverseAnInt
    {
        public static int ReverseInt(int num)
        {
            var result = 0;
            
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            
            return result;
        }
    }
}
