using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class ReverseALinkedListTest
    {
        [TestMethod]
        public void ReverseALinkedListReversesALinkedList()
        {
            var reverseALinkedList = new ReverseALinkedList();

            var results = reverseALinkedList.ReverseLinkedList(reverseALinkedList.DemoStringLinkedList());

            Assert.IsTrue(results.SequenceEqual(reverseALinkedList.DemoStringLinkedList().Reverse()));
        }
    }
}