using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.Console
{
    public class Highscore
    {
        public Highscore(int score, string game, string player, DateTime date)
        {
            this.score = score;
            this.game = game;
            this.player = player;
            this.date = date;
        }

        private int score;
        private string game;
        private string player;
        private DateTime date;

        public int GetScore()
        {
            return this.score;
        }
        public void SetScore(int score)
        {
            this.score = score;
        }

        public string GetGame()
        {
            return this.game;
        }

        public void SetGame(string game)
        {
            this.game = game;
        }

        public string GetPlayer()
        {
            return this.player;
        }

        public void SetPlayer(string player)
        {
            this.player = player;
        }

        public DateTime GetDate()
        {
            return this.date;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }

    }
}
