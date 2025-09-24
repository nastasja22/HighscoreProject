using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.ConsoleApp
{
    public class Highscore
    {
        public Highscore(int score, Game game, Player player, DateTime date)
        {
            this.score = score;
            this.game = game;
            this.player = player;
            this.date = date;
        }

        private int score;
        private Game game;
        private Player player;
        private DateTime date;

        public int GetScore()
        {
            return score;
        }
        public void SetScore(int score)
        {
            if (score < 0)
            {
                throw new ArgumentException("Score cannot be negative");
            }
            this.score = score;
        }

        public DateTime GetDate()
        {
            return date;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }

    }
}
