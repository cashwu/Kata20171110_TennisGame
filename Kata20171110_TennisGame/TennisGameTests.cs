using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171110_TennisGame
{
    [TestClass]
    public class TennisGameTests
    {
        private readonly TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void LoveAll()
        {
            AssertScoreShouldBe("Love All");
        }

        [TestMethod]
        public void FifteenLove()
        {
            tennisGame.PlayerOneScore();
            AssertScoreShouldBe("Fifteen Love");
        }

        private void AssertScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.Score());
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