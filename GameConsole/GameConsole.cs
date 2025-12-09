using GameConsole.Base;
using GameConsole.Models;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class GameConsole
    {
        public static User user;

        public GameConsole()
        {
            RunApplication();
        }

        public void RunApplication()
        {
            StartSc mainScreen = new MainMenu();
        }
    }

   
}
