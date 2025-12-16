using GameConsole.Base;
using GameConsole.Games;
using GameConsole.Interfaces;
using GameConsole.Pages;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartScreen s = new StartScreen();
            s.Show(); 
            MenuGames b = new MenuGames();
            b.Show();
           
           
        }
    }
}
