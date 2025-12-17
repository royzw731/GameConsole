using GameConsole.Base;
using GameConsole.Models;
using System;

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
            Console.WriteLine("Change Username");
            Console.Write("New username: ");
            string newUsername = Console.ReadLine();

            user.UserName = newUsername;

            Console.WriteLine("Username changed successfully");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}
