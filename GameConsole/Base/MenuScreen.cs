using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    public class MenuScreen : Screen
    {

        private List<MenuItem> items;
        public MenuScreen(string title) : base("WELCOME TO MENU SCREEN")
        {
            items = new List<MenuItem>();
        }
        public void AddItem(MenuItem item) { items.Add(item); }
        public void AddItem(string displayName, Screen screen) { items.Add(new MenuItem(displayName, screen)); }

    }
}
