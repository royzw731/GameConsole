using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Diagnostics.Metrics;

namespace GameConsole.Pages
{
    internal class ShowUserDetailsScreen : Screen
    {
        private User user;

        public ShowUserDetailsScreen() : base("INFO")
        {
            this.user = Program.getUser();
        }

        public override void Show()
        {
            base.Show();
            CenterText(user.Name);
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Username: {user.UserName}");
            Console.WriteLine($"Password: {user.Password}\n");

            List<HighScore> lst = user.getHighScores();

            
            if(lst.Count > 0)
            {
                scoreByTime(lst);
                scoreByName(lst);
                scoreByHighestScore(lst);
                HighestScore(lst);

            } else
            {
                Console.WriteLine("No games have been played, no scores found!");
            }

            


            Console.WriteLine();
            string ans = "";
            while(ans != "$")
            {
                    Console.WriteLine("Enter $ to return: ");
                    ans = Console.ReadLine() ?? "";
            }

            Screen newScreen = new UserActionMenu();
        }

        public void scoreByTime(List<HighScore> lst)
        {
            WithColor(ConsoleColor.Red, () =>
            {
                Console.WriteLine("User Score (Time order):");

                foreach (HighScore score in lst)
                {
                    Console.WriteLine($"Game: {score.Name}  [Score: {score.Points}  Time: {score.DateTime}]");
                }
            });
        }


        public void scoreByName(List<HighScore> lst)
        {
            WithColor(ConsoleColor.Yellow, () =>
            {
                Console.WriteLine("\nUser Score (Name order):");
            });

            PrintGameScores(lst, "Tetris", ConsoleColor.DarkYellow);
            PrintGameScores(lst, "Fluffy Bird", ConsoleColor.DarkYellow);
            PrintGameScores(lst, "Pac-Man", ConsoleColor.DarkYellow);
        }

        void PrintGameScores(List<HighScore> lst, string gameName, ConsoleColor scoreColor)
        {
            Console.WriteLine($"\n{gameName}:");
            int counter = 0;

            WithColor(scoreColor, () =>
            {
                foreach (HighScore score in lst)
                {
                    if (score.Name == gameName)
                    {
                        Console.WriteLine($"[Score: {score.Points}  Time: {score.DateTime}]");
                        counter++;
                    }
                }
            });

            if (counter == 0)
            {
                WithColor(ConsoleColor.DarkGray, () =>
                {
                    Console.WriteLine("No games have been played, no scores found!");
                });
            }
        }


        public void scoreByHighestScore(List<HighScore> lst)
        {
            WithColor(ConsoleColor.Green, () =>
            {
                Console.WriteLine("\nUser score (highest - lowest)");
            });

            List<HighScore> copy = new(lst);

            while (copy.Count != 0)
            {
                int maxPoints = -1;
                int maxIndex = 0;
                HighScore maxScore = copy[0];

                for (int i = 0; i < copy.Count; i++)
                {
                    if (copy[i].Points > maxPoints)
                    {
                        maxPoints = copy[i].Points;
                        maxScore = copy[i];
                        maxIndex = i;
                    }
                }

                WithColor(ConsoleColor.DarkGreen, () =>
                {
                    Console.WriteLine($"Game: {maxScore.Name}  [Score: {maxScore.Points}  Time: {maxScore.DateTime}]");
                });

                copy.RemoveAt(maxIndex);
            }
        }

        public void HighestScore(List<HighScore> lst) 
        {
            HighScore highScore = lst.First();
            int maxPoints = highScore.Points;

            foreach (HighScore i in lst) 
            {
                if(i.Points > maxPoints)
                {
                    highScore = i;
                    maxPoints = highScore.Points;
                }
            }

            WithColor(ConsoleColor.Blue, () => 
            {
                Console.WriteLine("\nHighset Score: ");
                Console.WriteLine($"Game: {highScore.Name}  [Score: {highScore.Points}  Time: {highScore.DateTime}]");
            });
        }


        void WithColor(ConsoleColor color, Action action)
        {
            var oldColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = color;
                action();
            }
            finally
            {
                Console.ForegroundColor = oldColor;
            }
        }

    }
}
