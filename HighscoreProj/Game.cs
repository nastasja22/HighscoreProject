using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.Console
{
    public class Game
    {
        public Game()
        {

        }

        public Game(string title, string genre, string publisher)
        {
            this.title = title;
            this.genre = genre;
            this.publisher = publisher;
        }

        private int id;
        private string title { get; set; }
        private string genre { get; set; }
        private string publisher { get; set; }
    }
}
