using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class LoginScreen : Screen
    {
        public LoginScreen() : base("LOGIN SCREEN")
        {
         
        }

        public override void Show()
        {
            base.Show();

            CenterText("Welcome back");
            Console.ReadKey();
        }
    }
}
