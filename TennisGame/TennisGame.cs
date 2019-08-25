namespace TennisGame
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public string Score()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }
    }
}