using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.Console
{
    public class Game
    {

        public Game(string title, string genre, string publisher)
        {
            this.Title = title;
            this.Genre = genre;
            this.Publisher = publisher;
        }

        private string Title { get; set; }
        private string Genre { get; set; }
        private string Publisher { get; set; }
        private DateTime ReleasedAt { get; set; }

    }
}
