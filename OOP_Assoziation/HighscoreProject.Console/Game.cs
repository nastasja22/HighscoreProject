using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.ConsoleApp
{
    public class Game
    {

        public Game(string title, string genre, string publisher, DateTime releasedAt)
        {
            this.title = title;
            this.genre = genre;
            this.publisher = publisher;
            this.releasedAt = releasedAt;
        }

        private string title;
        private string genre;
        private string publisher;
        private DateTime releasedAt;
        private List<Highscore> highscores = new List<Highscore>();

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetGenre()
        {
            return genre;
        }

        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public string GetPublisher()
        {
            return publisher;
        }

        public void SetPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public DateTime GetReleasedAt()
        {
            return releasedAt;
        }
        public void SetReleasedAt(DateTime releasedAt)
        {
            this.releasedAt = releasedAt;
        }

        public List<Highscore> GetHighscores()
        {
            return this.highscores;
        }

        public void AddHighscore(Highscore highscore)
        {
            highscores.Add(highscore);
        }
    }
}
