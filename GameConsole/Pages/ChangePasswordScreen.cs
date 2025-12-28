using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Threading;

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

            string oldPassword, newPassword;

            Console.Write("Enter old password: ");
            oldPassword = Console.ReadLine() ?? "";
            Console.Write("Enter new password: ");
            newPassword = Console.ReadLine() ?? "";

            if (oldPassword == user.Password)
            {
                Program.user.Password = newPassword;
                Console.WriteLine("password changed");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Wrong password! pls try again");
                    Console.Write("Old Password: ");
                    oldPassword = Console.ReadLine() ?? "";
                    Console.Write("New password: ");
                    newPassword = Console.ReadLine() ?? "";

                    if (oldPassword == user.Password)
                    {
                        Program.user.UserName = newPassword;
                        Console.WriteLine("password changed");
                        break;
                    }
                }
            }
            Thread.Sleep(1000);

        }
    }
}
