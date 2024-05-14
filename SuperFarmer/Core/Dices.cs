using SuperFarmer.Abstracts;
using SuperFarmer.Animals;

namespace SuperFarmer.Core;

public class Dice1 : Dice
{
    public Dice1()
    {
        AddAnimal(Animal.Rabbit, 6);
        AddAnimal(Animal.Sheep, 3);
        AddAnimal(Animal.Pig, 1);
        AddAnimal(Animal.Cow, 1);
        AddAnimal(Animal.Wolf, 1);
    }
}

public class Dice2 : Dice
{
    public Dice2()
    {
        AddAnimal(Animal.Rabbit, 6);
        AddAnimal(Animal.Sheep, 2);
        AddAnimal(Animal.Pig, 2);
        AddAnimal(Animal.Horse, 1);
        AddAnimal(Animal.Fox, 1);
    }
}