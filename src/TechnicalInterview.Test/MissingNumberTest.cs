using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class MissingNumberTest
    {
        public static int[] AllNumbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public static int[] HasMissingNumber = {0, 1, 2, 3, 4, 5, 6, 8, 9, 10};
        //Note: Missing number is 7 for those playing at home.

        [TestMethod]
        public void LinqFindMissingReturnsMissingNumber()
        {
            var missing = MissingNumbers.LinqFindMissing(AllNumbers, HasMissingNumber);
            Assert.AreNotEqual(missing, 0);
            Assert.AreEqual(missing, 7);
        }

        [TestMethod]
        public void FindMissingReturnsMissingNumber()
        {
            var missing = MissingNumbers.FindMissing(AllNumbers, HasMissingNumber);
            Assert.AreNotEqual(missing, 0);
            Assert.AreEqual(missing, 7);
        }
    }
}