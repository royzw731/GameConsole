using GameConsole.Base;
using GameConsole.Models;
using System;

namespace GameConsole.Pages
{
    internal class ChangePasswordScreen : Screen
    {
        private User user;

        public ChangePasswordScreen() : base("Change Password")
        {
            this.user = Program.getUser();
        }

        public override void Show()
        {
            base.Show();    
            Console.WriteLine("Change Password");
            Console.Write("New password: ");
            string newPassword = Console.ReadLine();

            user.Password = newPassword;

            Console.WriteLine("Password changed successfully");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}
