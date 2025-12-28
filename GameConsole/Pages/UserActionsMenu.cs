using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class UserActionsMenu : MenuScreen
    {
        private User user;

        public UserActionsMenu(string title, User user) : base("WRLCOME TO USER ACTIONS MENU!")
        {
            this.user = user;
            Add("Update User Name & Password", new UpdateUserName("Update User Details"));
        }
    }
}
