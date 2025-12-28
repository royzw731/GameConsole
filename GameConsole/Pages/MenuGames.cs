using GameConsole.Base;
using GameConsole.Games;
using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MenuGames : Screen
    {
        public MenuGames() : base(" Welcome to Games menu ")
        {
        }
        public override void Show()
        {
            base.Show();

            List<IGamePlay> games = new List<IGamePlay>
    {
        new FluffyBirdGame(),
        new PacManGame(),
        new TetrisGame()
    };

            for (int i = 0; i < games.Count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                if (i%3==0)
                {
                   Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (i%3==1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (i%3==2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                CenterText($"For {games[i].Name} enter {i + 1}");
                Console.ResetColor();
            }
            
            while (true)
            {
                string ans = Console.ReadLine() ?? "";

                if (int.TryParse(ans, out int num) && num > 0 && num <= games.Count)
                {
                    IGamePlay selectedGame = games[num - 1];
                    selectedGame.Play(); 
                    break;
                }

                Console.WriteLine("Please try again.");
            }
        }


    }
}
