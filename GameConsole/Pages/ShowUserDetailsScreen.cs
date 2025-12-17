using GameConsole.Base;
using GameConsole.Models;
using System;

namespace GameConsole.Pages
{
    internal class ShowUserDetailsScreen : Screen
    {
        private User user;

        public ShowUserDetailsScreen() : base("INFO")
        {
            this.user = Program.getUser();
        }

        public override void Show()
        {
            base.Show();
            CenterText(user.Name);
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Username: {user.UserName}");
            Console.WriteLine($"Password: {user.Password}\n");

            string ans = "";
            while(ans != "$")
            {
                    Console.WriteLine("Enter $ to return: ");
                    ans = Console.ReadLine() ?? "";
            }

            Screen newScreen = new UserActionMenu();
        }
    }
}
