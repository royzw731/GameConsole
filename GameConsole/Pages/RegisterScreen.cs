
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
    internal class RegisterScreen : Screen
    {
        private string name;
        private string username;
        private string password;
        private User user;
        public RegisterScreen() : base("Register")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter Your Desired Details");

            Console.Write("Enter name: ");
            this.name = Console.ReadLine() ?? "";
            Console.Write("Enter username: ");
            this.username = Console.ReadLine() ?? "";
            Console.Write("Enter password: ");
            this.password = Console.ReadLine() ?? "";

            user = UserDb.RegisterUser(name, username, password);
            if (user != null)
            {
                Console.WriteLine("Succsesfull!");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Error, pls try again-");

                    Console.Write("Enter name: ");
                    this.name = Console.ReadLine() ?? "";
                    Console.Write("Enter username: ");
                    this.username = Console.ReadLine() ?? "";
                    Console.Write("Enter password: ");
                    this.password = Console.ReadLine() ?? "";

                    user = UserDb.RegisterUser(name, username, password);
                    if (user != null)
                    {
                        Console.WriteLine("Succsesfull registerd!");
                        break;
                    }
                }
            }
            Thread.Sleep(1000);
        }
    }
}
