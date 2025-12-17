using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class UserActionMenu : MenuScreen
    {

        public UserActionMenu() : base("User Menu")
        {
            Add("Show user details", new ShowUserDetailsScreen());
            Add("Change password", new ChangePasswordScreen());
            Add("Change username", new ChangeUsernameScreen());
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
