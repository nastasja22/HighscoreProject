using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProj
{
    public class Highscore
    {
        public Highscore()
        {

        }

        public Highscore(int score)
        {
            this.score = score;
        }

        private int id;
        private int score { get; set; }
    }
}
