using SuperFarmer.UI;
using Terminal.Gui;

namespace SuperFarmer;

static class Program
{
    public static void Main(string[] args)
    {
        Application.Init();
        Application.Run(new MainGUI());
        Application.Shutdown();
    }
}

