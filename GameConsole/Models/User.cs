
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       public User(string name, string userName, string password)
        {
            this.name = name;
            this.userName = userName;
            this.password = password;
            this.highScores = new List<HighScore>();
        }

        
    }
}
