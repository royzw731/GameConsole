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
    {
        private UserDB userDB;

        public UpdateUserName(string title) : base("WELCOME TO UPDATING USERNAME AND PASSWORD")
        {

        }
        public override void Show()
        {
            bool success = false;

            while (!success)
            {
                base.Show();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                CenterText("Enter Your UserName");
                string username = Console.ReadLine();

                CenterText("Enter Your Password");
                string password = Console.ReadLine();

                User user = UserDb.Login(username, password);

                if (user != null)
                {
                    CenterText("Enter New UserName");
                    string newUsername = Console.ReadLine();

                    CenterText("Enter New Password");
                    string newPassword = Console.ReadLine();

                    UpdateNameAndPassword(user, newUsername, newPassword);
                    CenterText("Details updated successfully!");
                    success = true;
                }
                else
                {
                    CenterText("Wrong username or password. Try again.");
                }
            }
        }

        private void UpdateNameAndPassword(User user, string? newusername, string? newPassword)
        {
            throw new NotImplementedException();
        }
    }

}

