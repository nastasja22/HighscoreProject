using System;

namespace HighscoreProject.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Trevor", "Dans", "trevordans", "trevor.dans@gmail.com");
            Player player2 = new Player("Sarah", "Connor", "sarahconnor", "sarah.conn@gmail.com");

            Game game1 = new Game("The Last of Us", "Action-Adventure", "Naughty Dog", new DateTime(2013, 6, 14));
            Game game2 = new Game("God of War", "Action", "Santa Monica Studio", new DateTime(2018, 4, 20));
            Game game3 = new Game("Cyberpunk 2077", "RPG", "CD Projekt Red", new DateTime(2020, 12, 10));

            Highscore highscore1 = new Highscore(9500, game1, player1, DateTime.Now);
            Highscore highscore7 = new Highscore(9500, game1, player1, DateTime.Now);
            Highscore highscore8 = new Highscore(2323, game1, player1, DateTime.Now);
            Highscore highscore9 = new Highscore(1231, game1, player1, DateTime.Now);
            Highscore highscore4 = new Highscore(8800, game1, player2, DateTime.Now);
            Highscore highscore2 = new Highscore(8700, game2, player1, DateTime.Now);
            Highscore highscore5 = new Highscore(9900, game2, player2, DateTime.Now);
            Highscore highscore3 = new Highscore(9200, game3, player1, DateTime.Now);
            Highscore highscore6 = new Highscore(7600, game3, player2, DateTime.Now);

            player1.AddHighscore(highscore1);
            player1.AddHighscore(highscore7);
            player1.AddHighscore(highscore8);
            player1.AddHighscore(highscore9);
            player1.AddHighscore(highscore2);
            player1.AddHighscore(highscore3);
            player2.AddHighscore(highscore4);
            player2.AddHighscore(highscore5);
            player2.AddHighscore(highscore6);

            player1.PrintAllHighscores();
            player2.PrintAllHighscores();


            player1.PrintGameHighscores(game1);

            game1.AddHighscore(highscore1);
            game1.AddHighscore(highscore7);
            game1.AddHighscore(highscore8);
            game1.AddHighscore(highscore9);
            game1.AddHighscore(highscore4);

            game2.AddHighscore(highscore5);
            game2.AddHighscore(highscore2);

            game3.AddHighscore(highscore3);
            game3.AddHighscore(highscore6);

        }
    }
}
