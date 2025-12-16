using GameConsole.Base;
using GameConsole.Models;
using System;

namespace GameConsole.Pages
{
    internal class ViewUserDetails : Screen
    {
        private User user;

        public ViewUserDetails(string title, User user) : base("USER DETAILS")
        {
            this.user = user;
        }

        public override void Show()
        {
            base.Show();
            CenterText($"User Name: {user.UserName}");
            CenterText($"Password: {user.Password}");
            CenterText("Press any key to return");
            Console.ReadKey();
        }
    }
}
