using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreProj
{
    public class Player
    {
        public Player()
        {

        }

        public Player(string firstname, string lastName, string username, string email, int password)
        {
            this.firstName = firstname;
            this.lastName = lastName;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        private int id;
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string username { get; set; }
        private string email { get; set; }
        private int password { get; set; }

        public bool IsValidEmail(string email)
        {
            if (email.Contains("@"))
            {
                this.email = email;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
