
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

        public UserDb()
        {
            user1 = new List<User>();
        }
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
                    user.UserName = u.UserName;
                    user.Password = u.Password;
                    return;
                }
            }

            throw new InvalidOperationException("user doesn't exist");
        }
        public static void ChangePassword(User user, string password, string oldPassword, string username)
        {
            User newUser = user1.FirstOrDefault(u => u.Password == oldPassword && u.UserName == username);
        } public static void UpdateNameAndPassword(User q, String newuserName, String newPassword)
        {
            foreach(var user in user1)
            {
                if(user.Username == q.Username&& user.Password == q.Password)
                {
                    user.Username = newuserName;
                    user.Password = newPassword;
                }
            }
            
        }
    }
}
