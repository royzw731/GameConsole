using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameConsole.Pages
{
    public class StartScreen : Screen
    {
        private string ans;
        public StartScreen() : base("WELCOME TO OUR APP")
        {
            Show();
            MenuScreen newScreen = new MainMenu();
        }

        public override void Show()
        {
            base.Show();

            String bob = "DVIR HASSAN, ROY ZWILLING, YEHONATAN EDRI";
            CenterText(bob);

            Console.WriteLine("Enter $ to continue: ");
            ans = Console.ReadLine();

            while(ans != "$")
            {
                Console.WriteLine("No Bruh, Enter $ to continue: ");
                ans = Console.ReadLine();
            }
        }
    }

    
}
