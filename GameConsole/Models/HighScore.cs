
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        private string name;
        private int points;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        private DateTime dateTime;

        public HighScore()
        {
            dateTime = DateTime.Now;
            this.name = "";
            this.points = 0;
        }

        public HighScore(string name, int points)
        {
            dateTime = DateTime.Now;
            this.name = name;
            this.points = points;
        }
    }   
}
