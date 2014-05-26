using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void IsAnagramReturnsTrueForAnagram()
        {
            Assert.IsTrue(Anagram.IsAnagram("civic", "civic"));
        }

        [TestMethod]
        public void IsAnagramReturnsTrueForAnagramWithMixedCase()
        {
            Assert.IsTrue(Anagram.IsAnagram("ACT", "cat"));
        }

        [TestMethod]
        public void IsAnagramReturnsTrueForAnagramWithNonCharacters()
        {
            Assert.IsTrue(Anagram.IsAnagram("A.C.T$", "cat"));
        }

        [TestMethod]
        public void IsAnagramReturnsFalseForMissMatchedLengths()
        {
            Assert.IsFalse(Anagram.IsAnagram("testsetz", "testset"));
        }
    }
}