using System.Net.Quic;
using SuperFarmer.Animals;

namespace SuperFarmer.Core;

public class Player
{
    public AnimalHerd AnimalHerd { get; set; }
    public String Name { get; set; }
    
    public Player(string name)
    {
        AnimalHerd = new AnimalHerd();
        Name = name;
    }

    public bool IsAWinner()
    {
        var neededAnimals = new List<Animal>
        {
            Animal.Cow,
            Animal.Horse,
            Animal.Pig,
            Animal.Sheep,
            Animal.Rabbit
        };

        return !AnimalHerd.Animals.Any(pair => pair.Value == 0 && neededAnimals.Contains(pair.Key));
    }
}