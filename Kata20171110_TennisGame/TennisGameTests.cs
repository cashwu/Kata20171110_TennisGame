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

        [TestMethod]
        public void FortyLove()
        {
            PlayerOneScoreTime(3);
            AssertScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void LoveFifteen()
        {
            tennisGame.PlayerTwoScore();
            AssertScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void LoveThirty()
        {
            PlayerTwoScoreTime(2);
            AssertScoreShouldBe("Love Thirty");
        }

        private void PlayerTwoScoreTime(int time)
        {
            for (int i = 0; i < time; i++)
            {
                tennisGame.PlayerTwoScore();
            }
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
        private int playerTwoScore;

        public string Score()
        {
            Dictionary<int, string> scoreMapping = new Dictionary<int, string>
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };

            if (playerOneScore != 0 || playerTwoScore != 0)
            {
                return scoreMapping[playerOneScore] + " " + scoreMapping[playerTwoScore];
            }
            return "Love All";
        }

        public void PlayerOneScore()
        {
            this.playerOneScore++;
        }

        public void PlayerTwoScore()
        {
            this.playerTwoScore++;
        }
    }
}