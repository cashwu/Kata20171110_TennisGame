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

        [TestMethod]
        public void FifteenLove()
        {
            TennisGame tennisGame = new TennisGame();
            tennisGame.PlayerOneScore();
            string score = tennisGame.Score();
            Assert.AreEqual("Fifteen Love", score);
        }
    }

    public class TennisGame
    {
        private int playerOneScore;

        public string Score()
        {
            if (playerOneScore != 0)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void PlayerOneScore()
        {
            this.playerOneScore++;
        }
    }
}