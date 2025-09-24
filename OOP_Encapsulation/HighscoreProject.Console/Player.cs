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

            if (IsValidEmail(email))
            {
                this.email = email;
            }
            else
            {
                throw new ArgumentException("Invalid email format");
            }
        }

        private string firstName;
        private string lastName;
        private string username;
        private string email;

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
            if (IsValidEmail(email))
            {
                this.email = email;
            }
            else
            {
                throw new ArgumentException("Invalid email format");
            }
        }

        public bool IsValidEmail(string email)
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
