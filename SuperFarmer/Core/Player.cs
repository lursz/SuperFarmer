using SuperFarmer.Animals;

namespace SuperFarmer.Core;

public class Player
{
    AnimalHerd AnimalHerd { get; set; }
    String Name { get; set; }
    
    public Player(string name)
    {
        AnimalHerd = new AnimalHerd();
        Name = name;
    }
}