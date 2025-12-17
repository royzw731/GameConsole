using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Games;
using GameConsole.Interfaces;
using GameConsole.Models;
using GameConsole.Pages;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace GameConsole
{
    internal class Program
    {

        public static User user;
        static void Main(string[] args)
        {
            RunApp();
        }

        private static void RunApp()
        {
            Screen stScreen = new StartScreen();
        }

        public static User getUser() { return user; }
        public static void setUser(User u) 
        {
            user = new User(u.Name, u.UserName, u.Password);
        }
    }
}
