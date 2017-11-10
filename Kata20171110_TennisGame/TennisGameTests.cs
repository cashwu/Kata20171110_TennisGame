using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void ThirtyLove()
        {
            PlayerOneScoreTime(2);
            AssertScoreShouldBe("Thirty Love");
        }

        private void PlayerOneScoreTime(int time)
        {
            for (int i = 0; i < time; i++)
            {
                tennisGame.PlayerOneScore();
            }
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
            Dictionary<int, string> scoreMapping = new Dictionary<int, string>
            {
                {1, "Fifteen"},
                {2, "Thirty"}
            };

            if (playerOneScore != 0)
            {
                return scoreMapping[playerOneScore] + " Love";
            }
            return "Love All";
        }

        public void PlayerOneScore()
        {
            this.playerOneScore++;
        }
    }
}