using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public string Score()
        {
            var lookupdic = new Dictionary<int, string>()
            {
                [0] = "Love",
                [1] = "Fifteen",
                [2] = "Thirty",
                [3] = "Forty"
            };
            if (_firstPlayerScore > 0 || _secondPlayerScore > 0)
            {
                return $"{lookupdic[_firstPlayerScore]} {lookupdic[_secondPlayerScore]}";
            }

            return "Love All";
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}