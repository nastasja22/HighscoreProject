using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.Console
{
    public class Highscore
    {
        public Highscore(int score)
        {
            this.Score = score;
        }

        private int Score { get; set; }

        public int High { get; set; }

    }
}
