using SuperFarmer.Core;
using SuperFarmer.UI;
using Terminal.Gui;

namespace SuperFarmer;

static class Program
{
    public static void Main(string[] args)
    {
        Application.Init();
        Game game = new Game();

        Application.Run(new MainGUI(game));
        Program.GameLoop(game);
        Application.Shutdown();
    }

    public static void GameLoop(Game game)
    {
        while (!game.gameStopped && !game.IsCurrentPlayerWinner())
        {
            game.RollDices();
            game.NextPlayer();
        }
        
        MessageBox.ErrorQuery("Game Over", $"{game.CurrentPlayer.Name} is the winner!", "Ok");
    }
}

