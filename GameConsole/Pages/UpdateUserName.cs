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

    public class UpdateUserName : Screen
    {
        private UserDB userDB;

        public UpdateUserName(string title) : base(title)
        {

        }
        public override void Show()
        {
           
            bool flag = false;
            while(flag!= true)
            {
                base.Show();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                CenterText("Enter Your UserName");
                String c = Console.ReadLine();
                CenterText("Enter Your password");
                String s = Console.ReadLine();

                if (UserDb.Login(c, s)!= null)
                {
                   User user = UserDb.Login(c, s);
                    Console.WriteLine("Enter new UserName");
                    String newusername = Console.ReadLine();
                    Console.WriteLine("Enter new Password");
                    String newPassword = Console.ReadLine();
                    UpdateNameAndPassword(user, newusername, newPassword);
                    flag = true;
                } 
            }
        }
        private void UpdateNameAndPassword(User user, string? newusername, string? newPassword)
        {
            throw new NotImplementedException();
        }
    }

}

