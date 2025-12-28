using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    internal class MenuScreen : Screen
    {
        private List<MenuItem> items;

        public MenuScreen(string title) : base(title)
        {
            items = new List<MenuItem>();
        }
        public void Add(MenuItem item)
        {
            if (item != null)
                items.Add(item);
        }
        public void Add(string displayName, Screen sc)
        {
            items.Add(new MenuItem(displayName, sc));
        }
        public override void Show()
        {
            while (true)
            {
                Console.Clear();
                base.Show();

                CenterText("Choose your Screen:");

                for (int i = 0; i < items.Count; i++)
                {
                    CenterText($"{i + 1} - {items[i].DisplayName}");
                }

                CenterText($"{items.Count + 1} - Exit");
                CenterText($"Choose between (1-{items.Count + 1})");

                if (!int.TryParse(Console.ReadLine(), out int choose))
                    continue;

                if (choose == items.Count + 1)
                    return;

                if (choose < 1 || choose > items.Count)
                    continue;

                items[choose - 1].Screen.Show();
            }
        }


    }
}