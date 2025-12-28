
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Towel;

namespace GameConsole.Models
{
    internal class User
    {
        private string name;
        private string userName;
        private string password;
        private List<HighScore> highScores;

        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string UserName { get { return userName; } set { userName = value; } }

        public User(string name, string username, string password)
        {
            this.name = name;
            this.userName = username;
            this.password = password;
            this.highScores = new List<HighScore>();
        }

        public void addNewScore(HighScore highScore)
        {
            highScores.Add(highScore);  
        }

        public List<HighScore> getHighScores() { return highScores; }
    }
}
