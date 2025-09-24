using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.Console
{
    public class Player
    {
        public Player(string firstname, string lastName, string username, string email)
        {
            this.firstName = firstname;
            this.lastName = lastName;
            this.username = username;

            //Variant of email validation 
            if (IsValidEmail(email))
            {
                this.email = email;
            }
            else
            {
                throw new ArgumentException("Invalid email format");
            }

            //Variante 2 to initialize the list
            //List must be initialized to avoid null reference exceptions => can be done by field as well
            //this.highscores = new List<Highscore>();
        }

        private string firstName;
        private string lastName;
        private string username;
        private string email;
        //Variante 1 to initialize the list
        //List must be initialized to avoid null reference exceptions => can be done in constructor as well
        private List<Highscore> highscores = new List<Highscore>();

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(string firstname)
        {
            this.firstName = firstname;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            //Variant of email validation 
            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email format");
            }
            this.email = email;
        }

        public List<Highscore> GetHighscores()
        {
            return this.highscores;
        }

        public void AddHighscore(Highscore highscore)
        {
            this.highscores.Add(highscore);
        }

        private static bool IsValidEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
