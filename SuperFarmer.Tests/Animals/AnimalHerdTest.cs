using System;
using JetBrains.Annotations;
using SuperFarmer.Animals;
using Xunit;

namespace SuperFarmer.Tests.Animals;

[TestSubject(typeof(AnimalHerd))]
public class AnimalHerdTest : IDisposable
{

    public AnimalHerdTest()
    {
    }
    
    [Fact]
    public void Test_ExchangeAnimal1()
    {
        var animalHerd = new AnimalHerd();
        animalHerd.Animals[Animal.Rabbit] = 20;
        animalHerd.Animals[Animal.Sheep] = 12;
        animalHerd.Animals[Animal.Pig] = 6;
        animalHerd.Animals[Animal.Cow] = 2;
        animalHerd.Animals[Animal.Horse] = 1;
        
        var otherAnimalHerd = new AnimalHerd();
        otherAnimalHerd.Animals[Animal.Rabbit] = 10;
        otherAnimalHerd.Animals[Animal.Sheep] = 6;
        otherAnimalHerd.Animals[Animal.Pig] = 3;
        otherAnimalHerd.Animals[Animal.Cow] = 1;
        otherAnimalHerd.Animals[Animal.Horse] = 0;
        
        animalHerd.ExchangeAnimal(otherAnimalHerd, Animal.Rabbit, Animal.Sheep, 5);
        Assert.Equal(15, animalHerd.Animals[Animal.Rabbit]);
    }
    
    [Fact]
    public void Test_ExchangeAnimal2()
    {
        var animalHerd = new AnimalHerd();
        animalHerd.Animals[Animal.Rabbit] = 20;
        animalHerd.Animals[Animal.Sheep] = 12;
        animalHerd.Animals[Animal.Pig] = 6;
        animalHerd.Animals[Animal.Cow] = 2;
        animalHerd.Animals[Animal.Horse] = 1;
        
        var otherAnimalHerd = new AnimalHerd();
        otherAnimalHerd.Animals[Animal.Rabbit] = 10;
        otherAnimalHerd.Animals[Animal.Sheep] = 6;
        otherAnimalHerd.Animals[Animal.Pig] = 3;
        otherAnimalHerd.Animals[Animal.Cow] = 1;
        otherAnimalHerd.Animals[Animal.Horse] = 0;
        
        animalHerd.ExchangeAnimal(otherAnimalHerd, Animal.Rabbit, Animal.Sheep, 5);
        Assert.Equal(5, otherAnimalHerd.Animals[Animal.Sheep]);
    }

    public void Dispose()
    {
    }
}