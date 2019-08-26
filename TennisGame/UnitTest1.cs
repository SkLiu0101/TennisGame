using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame
{
    [TestClass]
    public class TennisGameTests
    {
        protected internal TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Fifteen_Love()
        {
            GiveFirstPlayerScore(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            GiveFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            GiveSecondPlayerScore(1);
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Forty()
        {
            GiveSecondPlayerScore(3);
            ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GiveSecondPlayerScore(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GiveFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        private void GiveFirstPlayerScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }

        private void GiveSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private void ScoreShouldBe(string lookup)
        {
            Assert.AreEqual(lookup, tennisGame.Score());
        }
    }
}