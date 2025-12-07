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
        public MenuGames(string title) : base(" Welcome to Games menu ")
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
                CenterText($"For {games[i].Name} enter {i + 1}");
            }
            
            while (true)
            {
                string ans = Console.ReadLine();

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
