using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class NumberOfBitsInIntegerTest
    {
        [TestMethod]
        public void CountBitsReturnsCorrectBitsForInteger()
        {
            var expecting1 = NumberOfBitsInInteger.CountBits(1);
            Assert.AreEqual(expecting1, 1);

            var expecting2 = NumberOfBitsInInteger.CountBits(5);
            Assert.AreEqual(expecting2, 2);

            var expecting8 = NumberOfBitsInInteger.CountBits(255);
            Assert.AreEqual(expecting8, 8);
        }
    }
}
