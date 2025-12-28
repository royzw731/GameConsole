using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MainMenu : MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Add("Register", new RegisterScreen());
            Add("Login", new LoginScreen());
            Show();
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
