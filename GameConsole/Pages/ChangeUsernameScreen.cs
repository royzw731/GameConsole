using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Threading;

namespace GameConsole.Pages
{
    internal class ChangeUsernameScreen : Screen
    {
        private User user;

        public ChangeUsernameScreen() : base("Change Username")
        {
            this.user = Program.getUser();
        }

        public override void Show()
        {
            base.Show();

            string username, password; 

            Console.Write("New username: ");
            username = Console.ReadLine() ?? "";
            Console.Write("Password: ");
            password = Console.ReadLine() ?? "";

            if (password == user.Password)
            {
                Program.user.UserName = username;
                Console.WriteLine("username changed");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Wrong password! pls try again");
                    Console.Write("New username: ");
                    username = Console.ReadLine() ?? "";
                    Console.Write("Password: ");
                    password = Console.ReadLine() ?? "";

                    if (password == user.Password)
                    {
                        Program.user.UserName = username;
                        Console.WriteLine("username changed");
                        break;
                    }
                }
            }
            Thread.Sleep(1000); 
        }
    }
}
