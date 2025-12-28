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
        }

        public override void Show()
        {
            while (true)
            {
                base.Show();

                String bob = "DVIR HASSAN, ROY ZWILLING, YEHONATAN EDRI";
                CenterText(bob);

                Console.WriteLine("Enter $ to continue: ");
                ans = Console.ReadLine() ?? "";

                while (ans != "$")
                {
                    Console.WriteLine("No, Enter $ to continue: ");
                    ans = Console.ReadLine() ?? "";
                }

                Screen newScreen = new MainMenu();
            }

        }
    }

    
}
