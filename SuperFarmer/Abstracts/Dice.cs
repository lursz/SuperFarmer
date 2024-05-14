using SuperFarmer.Animals;

namespace SuperFarmer.Abstracts;

using System.Collections.Specialized;

public abstract class Dice
{
    ListDictionary AnimalMap { get; set; } = new ListDictionary();
    int TotalCount { get; set; }
 
    Random random = new Random();
    
    protected void AddAnimal(Animal animal, int count)
    {
        AnimalMap.Add(animal, count);
        TotalCount += count;
    }

    public Animal Roll()
    {
        var roll = random.Next(0, TotalCount);
        var count = 0;

        foreach (Animal animal in AnimalMap.Keys)
        {
            var maybeCount = AnimalMap[animal];
            
            if (maybeCount is not int)
            {
                throw new Exception("Invalid count");
            }
            
            count += (int) maybeCount;
            if (roll <= count)
            {
                return animal;
            }
        }

        return AnimalMap.Keys.Cast<Animal>().Last();
    }
}