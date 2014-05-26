using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class PrimeNumberTest
    {
        private static int[] Primes = {2, 3, 5, 7, 11, 13, 17, 19, 23};
        private static int[] NotPrimes = {1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24};

        [TestMethod]
        public void IsPrimeCorrectlyIdentifiesPrimeNumber()
        {
            foreach (var number in Primes)
            {
                Assert.IsTrue(PrimeNumber.IsPrime(number));
            }
        }

        [TestMethod]
        public void IsPrimeCorrectlyIdentifiesNormalNumbersAsNotPrime()
        {
            foreach (var number in NotPrimes)
            {
                Assert.IsFalse(PrimeNumber.IsPrime(number));
            }
        }
    }
}