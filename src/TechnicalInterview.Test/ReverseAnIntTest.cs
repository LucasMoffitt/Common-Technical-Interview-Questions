using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class ReverseAnIntTest
    {
        [TestMethod]
        public void Stuff()
        {
            var reversedIn = ReverseAnInt.ReverseInt(123);
            Console.WriteLine(reversedIn);
            var shit = "stitcks";
        }
    }
}
