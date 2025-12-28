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
        public LoginScreen() : base("Login")
        {
         
        }
        public override void Show()
        {
            base.Show();
  
            string UserName = "", Password = "";
            int tries = 3;
            bool flag = false;

    
            
            for(int i = 0;i < tries;i++)
            {
                if(i > 0) Console.WriteLine("\nFail, pls try again");
                Console.Write("Enter username: ");
                UserName = Console.ReadLine() ?? "";
                Console.Write("Enter password: ");
                Password = Console.ReadLine() ?? "" ;

                if(UserDb.Login(UserName, Password) != null)
                {
                    flag = true;
                    break;
                }
            }

            if(flag)
            {
                User currentUser = new User(UserDb.Login(UserName, Password).Name, UserName, Password);
                Program.setUser(currentUser);

                Console.WriteLine("Login successful");
                Thread.Sleep(1000);
                Screen newScreen = new LoginMenu();
            } else
            {
                Console.WriteLine("Login failed");
                Thread.Sleep(1000);
            }
         }
    }
}
