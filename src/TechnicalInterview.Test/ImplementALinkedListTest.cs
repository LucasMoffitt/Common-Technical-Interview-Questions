using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class ImplementALinkedListTest
    {
        [TestMethod]
        public void AddingANodeIncrementsCount()
        {
            var list = new LinkedList();
            list.Add(new Node("Lucas"));

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void HeadIsNotNullAfterAddingANode()
        {
            var list = new LinkedList();
            list.Add(new Node("Lucas"));

            Assert.IsNotNull(list.Head);
        }

        [TestMethod]
        public void HeadReturnsFirstNode()
        {
            var list = new LinkedList();
            list.Add(new Node("Lucas"));
            list.Add(new Node("James"));
            list.Add(new Node("Moffitt"));
 
            Assert.AreEqual("Lucas", list.Head.Value);
        }

        [TestMethod]
        public void TailReturnsLastNode()
        {
            var list = new LinkedList();
            list.Add(new Node("Lucas"));
            list.Add(new Node("James"));
            list.Add(new Node("Moffitt"));

            Assert.AreEqual("Moffitt", list.Tail.Value);
        }

        [TestMethod]
        public void TailIsNotNullAfterAddingANode()
        {
            var list = new LinkedList();
            list.Add(new Node("Lucas"));

            Assert.IsNotNull(list.Tail);
        }

        [TestMethod]
        public void GetByIndexReturnsCorrectNode()
        {
            var list = new LinkedList();
            list.Add(new Node("Lucas"));
            list.Add(new Node("James"));
            list.Add(new Node("Moffitt"));

            var nth = list.GetByIndex(2);

            Assert.AreEqual(nth.Value, "Moffitt");
        }

        [TestMethod]
        public void ReverseListReversesList()
        {
           throw new NotImplementedException();
        }
    }
}