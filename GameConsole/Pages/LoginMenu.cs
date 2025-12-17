using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class LoginMenu : MenuScreen
    {
        public LoginMenu() : base("Hello " + Program.getUser().Name)
        {
            Add("userActionMenu", new UserActionMenu());
            Add("menuGames", new MenuGames());

            Show();
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
