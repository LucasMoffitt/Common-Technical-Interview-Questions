using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class ReverseAStringTest
    {
        private readonly string[] _stringData = {"stuff", "things, superduperlongstringlol", "stringwithwhitespace"};

        [TestMethod]
        public void ReverseAStringReversesAString()
        {
            foreach (var data in _stringData)
            {
                var reversed = ReverseAString.ReverseString(data);

                Assert.IsFalse(string.IsNullOrEmpty(reversed));

                var linqReversed = data.Reverse();

                Assert.AreSame(linqReversed, reversed);
            }
        }
    }
}
