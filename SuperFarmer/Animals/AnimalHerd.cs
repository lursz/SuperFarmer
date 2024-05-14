using SuperFarmer.Abstracts;

namespace SuperFarmer.Animals;

public class AnimalHerd
{
    public Dictionary<Animal, int> Animals = new Dictionary<Animal, int>
    {
        {Animal.Rabbit, 0},
        {Animal.Sheep, 0},
        {Animal.Pig, 0},
        {Animal.Cow, 0},
        {Animal.Horse, 0},
        {Animal.Dog, 0},
        {Animal.Hound, 0}
    };
    
    public Dictionary<Animal, int> Prices = new Dictionary<Animal, int>
    {
        {Animal.Rabbit, 1},
        {Animal.Sheep, 6},
        {Animal.Pig, 12},
        {Animal.Cow, 36},
        {Animal.Horse, 72},
        {Animal.Dog, 6},
        {Animal.Hound, 36}
    };
    
    public void ExchangeAnimal(AnimalHerd other, Animal animalToGo, Animal animalToGet, int quantityToGo) {
        var priceToGo = Prices[animalToGo];
        var priceToGet = Prices[animalToGet];
        
        var ownQuantity = Animals[animalToGo];
        var otherQuantity = other.Animals[animalToGet];
        var reducedQuantity = Math.Min(quantityToGo, ownQuantity);
        
        var acquiredQuantity = reducedQuantity * priceToGo / priceToGet;
        var possibleQuantity = Math.Min(acquiredQuantity, otherQuantity);
        
        var realQuantityToRemove = possibleQuantity * priceToGet / priceToGo;
        var realQuantityToAdd = realQuantityToRemove * priceToGo / priceToGet;
        
        Animals[animalToGo] -= realQuantityToRemove;
        other.Animals[animalToGet] -= realQuantityToAdd;
        
        Animals[animalToGet] += realQuantityToAdd;
        other.Animals[animalToGo] += realQuantityToRemove;
        
        Console.WriteLine($"Own quantity: {ownQuantity}");
        Console.WriteLine($"Other quantity: {otherQuantity}");
        Console.WriteLine($"Reduced quantity: {reducedQuantity}");
        
        Console.WriteLine($"Acquired quantity: {acquiredQuantity}");
        Console.WriteLine($"Possible quantity: {possibleQuantity}");
        
        Console.WriteLine($"Real quantity to remove: {realQuantityToRemove}");
        Console.WriteLine($"Real quantity to add: {realQuantityToAdd}");
        
        Console.WriteLine($"Own {animalToGo}: {Animals[animalToGo]}");
        Console.WriteLine($"Own {animalToGet}: {Animals[animalToGet]}");
        
        Console.WriteLine($"Exchanged {realQuantityToRemove} {animalToGo} for {realQuantityToAdd} {animalToGet}");
    }
}