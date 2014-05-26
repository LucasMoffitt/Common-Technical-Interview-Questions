using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class RemoveDuplicatesFromArrayTest
    {
        [TestMethod]
        public void RemovesDuplicatesFromArrayRemovesDuplicatesAndShortensArraySize()
        {
            var results = RemoveDuplicatesFromArray.RemoveDuplicateInts(new[] {1, 2, 1, 0, 0, 0, 3, 4, 1, 5, 2});

            Assert.IsNotNull(results);

            Assert.IsTrue(results.Contains(0));
            Assert.IsTrue(results.Contains(1));
            Assert.IsTrue(results.Contains(2));
            Assert.IsTrue(results.Contains(3));
            Assert.IsTrue(results.Contains(4));
            Assert.IsTrue(results.Contains(5));

            Assert.AreEqual(6, results.Length);
        }
    }
}