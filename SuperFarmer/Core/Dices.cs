using SuperFarmer.Abstracts;
using SuperFarmer.Animals;
using SuperFarmer.Animals.Farm;

namespace SuperFarmer.Core;

public class Dice1 : Dice
{
    public Dictionary<Animal, int> AnimalMap { get; set; }
    
    public Dice1()
    {
        AnimalMap = new Dictionary<Animal, int>();
        AnimalMap.Add(new Rabbit(), 6);
        AnimalMap.Add(new Sheep(), 3);
        AnimalMap.Add(new Pig(), 1);
        AnimalMap.Add(new Cow(), 1);
        AnimalMap.Add(new Wolf(), 1);
        
    }
}

public class Dice2 : Dice
{
    public Dictionary<Animal, int> AnimalMap { get; set; }
    
    public Dice2()
    {
        AnimalMap = new Dictionary<Animal, int>();
        AnimalMap.Add(new Rabbit(), 6);
        AnimalMap.Add(new Sheep(), 2);
        AnimalMap.Add(new Pig(), 2);
        AnimalMap.Add(new Horse(), 1);
        AnimalMap.Add(new Fox(), 1);
        
    }
}