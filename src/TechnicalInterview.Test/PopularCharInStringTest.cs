using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class PopularCharInStringTest
    {    
        [TestMethod]
        public void MostPopularCharInStringReturnsMostPopularChar()
        {
            var output = PopularCharInString.MostPopular("asdsdidsfdsieiwfoinsjffahjajwekhjfewhjqkafakj");
            
            Assert.AreEqual('f', output);
        }

        [TestMethod]
        public void MostPopularCharInStringDealsWithShortInputStrings()
        {
            try
            {
                var output = PopularCharInString.MostPopular("a");
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void MostPopularCharInStringDealsWithWhitespace()
        {
            var output = PopularCharInString.MostPopular("a b cc ddd");
            Assert.AreEqual('d', output);
        }
        
        [TestMethod]
        public void LinqMostPopularCharInStringReturnsMostPopularChar()
        {
            var output = PopularCharInString.LinqMostPopular("asdsdidsfdsieiwfoinsjffahjajwekhjfewhjqkafakj");

            Assert.AreEqual('f', output);
        }
    }
}