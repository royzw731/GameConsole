
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UserDb
    {
        private static List<User> user1;



        public static User RegisterUser(string name, string userName, string password)
        {
            User newUser = new User(name, userName, password);
            user1.Add(newUser);

            return newUser;
        }

        public static User Login(string username, string password)
        {
            foreach (var user in user1)
            {
                if (user.UserName == username && user.Password == password)
                { return user; }
            }

            return null;
        }

        public static void Update(User u)
        {
            foreach (var user in user1)
            {
                if (user.UserName == u.UserName)
                {
                    u.UserName = user.UserName;
                    u.Password = user.Password;
                    return;
                }
            }

            throw new InvalidOperationException("user doesn't exist");
        }
    }
}
