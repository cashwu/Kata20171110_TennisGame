using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171110_TennisGame
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void LoveAll()
        {
            TennisGame tennisGame = new TennisGame();
            string score = tennisGame.Score();
            Assert.AreEqual("Love All", score);
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            return "Love All";
        }
    }
}