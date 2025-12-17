using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("Enter Your Desired Details");
            String UserName, Password;
            base.Show();
            CenterText("Enter Login Info");
            CenterText("Enter User Name");
            UserName = Console.ReadLine();
            CenterText("Enter password");
            Password = Console.ReadLine();
            
            while(UserDb.Login(UserName, Password) == null)
            {
                CenterText("Fail, pls try again");
                CenterText("Enter User Name");
                UserName = Console.ReadLine();
                CenterText("Enter password");
                Password = Console.ReadLine();
            }

            User currentUser = new User(UserDb.Login(UserName, Password).Name, UserName, Password);
            Program.setUser(currentUser);

            Screen newScreen = new LoginMenu();
         }
    }
}
