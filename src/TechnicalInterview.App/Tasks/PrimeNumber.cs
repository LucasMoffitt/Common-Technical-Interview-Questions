namespace TechnicalInterview.App.Tasks
{
    public static class PrimeNumber
    {
        //Task:
        /*
         * Establish if a given integer is a prime number
         */
        public static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                if (number == 2)
                    return true;

                return false;
            }

            for (var i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }

            return number != 1;
        }
    }
}