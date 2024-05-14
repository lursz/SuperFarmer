using System;
using JetBrains.Annotations;
using SuperFarmer.Animals;
using Xunit;

namespace SuperFarmer.Tests.Animals;

[TestSubject(typeof(AnimalsASCII))]
public class AnimalsASCIITest : IDisposable
{
    AnimalsASCIITest()
    {
    }

    [Fact]
    public void Test_stringToAnimal1()
    {
        var animal = AnimalsASCII.stringToAnimal(AnimalsASCII.Rabbit);
        Assert.Equal(Animal.Rabbit, animal);
    }
    
    [Fact]
    public void Test_stringToAnimal2()
    {
        var animal = AnimalsASCII.stringToAnimal(AnimalsASCII.Sheep);
        Assert.Equal(Animal.Sheep, animal);
    }
    
    [Fact]
    public void Test_stringToAnimal3()
    {
        var animal = AnimalsASCII.stringToAnimal(AnimalsASCII.Pig);
        Assert.Equal(Animal.Pig, animal);
    }
    
    [Fact]
    public void Test_stringToAnimal4()
    {
        var animal = AnimalsASCII.stringToAnimal(AnimalsASCII.Cow);
        Assert.Equal(Animal.Cow, animal);
    }
    
    [Fact]
    public void Test_stringToAnimal5()
    {
        var animal = AnimalsASCII.stringToAnimal(AnimalsASCII.Horse);
        Assert.Equal(Animal.Horse, animal);
    }

    public void Dispose()
    {
    }
}