using GameConsole.Base;
using GameConsole.Data;
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
            CenterText("Enter Your Desired Details");
            Console.ReadKey();
            String UserName, Password;
            base.Show();
            CenterText("Enter Login Info");

            CenterText("Enter User Name");
            UserName = Console.ReadLine();
            CenterText("Enter password");
            Password = Console.ReadLine();
            if (UserDb.Login(UserName, Password) != null)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Login Failed, please try again");
            }
        }
        }
}
