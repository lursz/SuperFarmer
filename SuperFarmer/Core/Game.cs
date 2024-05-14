using SuperFarmer.Animals;

namespace SuperFarmer.Core;

public class Game
{
    public List<Player> Players { get; set; }
    public AnimalHerd GlobalHerd { get; set; }
    
    
    
    public Game()
    {
        GlobalHerd = new AnimalHerd();
        
        Players = new List<Player>();
        Players.Add(new Player("Player 1"));
        Players.Add(new Player("Player 2"));
    }
    
}