using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class MainMenu : MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            AddItem(new MenuItem("Register", new RegisterScreen()));
            AddItem("Login", new LoginScreen());
        }
    }
}
