using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class FindNumbersThatEqualTest
    {
        [TestMethod]
        public void FindsSumOfNumbersInInputThatEqualMatch()
        {
            var result = FindNumbersThatEqual.FindNumbersFromInputThatEqualGivenInt(new[] {1, 2, 3, 4, 5}, 5);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [TestMethod]
        public void FindsSumOfNumbersInInputThatEqualMatchWithLargerInputs()
        {
            var result = FindNumbersThatEqual.FindNumbersFromInputThatEqualGivenInt(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}, 43);

            Assert.IsNotNull(result);
            Assert.AreEqual(18, result[0]);
            Assert.AreEqual(25, result[1]);

        }

        [TestMethod]
        public void FindSumOfNUmbersInInputReturnsNullWhenNoMatchIsFound()
        {
            var result = FindNumbersThatEqual.FindNumbersFromInputThatEqualGivenInt(new[] {3, 4, 5, 6}, 5);
            Assert.IsNull(result);
        }
    }
}
