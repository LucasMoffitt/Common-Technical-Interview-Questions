using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class FindACelebrityTest
    {
        [TestMethod]
        public void CelebrityIsFound()
        {
            var party = new Party();
            party.StartParty();

            var celebrities = party.FindCelebrities();

            Assert.IsNotNull(celebrities);
            Assert.AreSame(2, celebrities.Count);
        }
    }
}
