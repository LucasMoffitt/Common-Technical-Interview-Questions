using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class ImplementAStackTest
    {
        [TestMethod]
        public void StackAcceptsMultipleItems()
        {
            var stack = new CustomStack<string>();

            for (var i = 0; i < 10; i++)
            {
                stack.Push(string.Format("Stack Item: {0}", i));
            }
        }

        [TestMethod]
        public void StackPopRemovesItem()
        {
        }

        private CustomStack<string> PopulateStack()
        {
            var stack = new CustomStack<string>();

            for (var i = 0; i < 10; i++)
            {
                stack.Push(string.Format("Stack Item: {0}", i));
            }

            return stack;
        } 
    }
}
