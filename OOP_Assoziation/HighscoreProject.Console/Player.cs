using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProject.ConsoleApp
{
    public class Player
    {
        public Player(string firstname, string lastName, string username, string email)
        {
            firstName = firstname;
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
            return firstName;
        }

        public void SetFirstName(string firstname)
        {
            firstName = firstname;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }

        public string GetEmail()
        {
            return email;
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
            return highscores;
        }

        public void AddHighscore(Highscore highscore)
        {
            highscores.Add(highscore);
        }

        public void PrintAllHighscores()
        {
            foreach (var highscore in highscores)
            {
                Console.WriteLine($"Player: {this.username}, Game: {highscore.GetGame().GetTitle()} ,Score: {highscore.GetScore()}, Date: {highscore.GetDate()}");
            }
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
