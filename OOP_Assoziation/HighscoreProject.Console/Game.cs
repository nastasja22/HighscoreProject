using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.Console
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

        public string GetTitle()
        {
            return this.title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetGenre()
        {
            return this.genre;
        }

        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public string GetPublisher()
        {
            return this.publisher;
        }

        public void SetPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public DateTime GetReleasedAt()
        {
            return this.releasedAt;
        }
        public void SetReleasedAt(DateTime releasedAt)
        {
            this.releasedAt = releasedAt;
        }



    }
}
