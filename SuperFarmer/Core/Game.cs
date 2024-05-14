using SuperFarmer.Abstracts;
using SuperFarmer.Animals;
using Terminal.Gui;

namespace SuperFarmer.Core;

public class Game
{
    int currentPlayerIndex = 0;
    
    public List<Player> Players { get; set; }
    public AnimalHerd GlobalHerd { get; set; }
    public Player CurrentPlayer => Players[currentPlayerIndex];
    public List<Dice> ListOfDices { get; set; }
    public Boolean gameStopped { get; set; } = false;
    
    
    public Game()
    {
        GlobalHerd = new AnimalHerd();
        GlobalHerd.Animals[Animal.Rabbit] = 60;
        GlobalHerd.Animals[Animal.Sheep] = 24;
        GlobalHerd.Animals[Animal.Pig] = 20;
        GlobalHerd.Animals[Animal.Cow] = 12;
        GlobalHerd.Animals[Animal.Horse] = 6;
        GlobalHerd.Animals[Animal.Dog] = 4;
        GlobalHerd.Animals[Animal.Hound] = 2;
        ListOfDices = new List<Dice>();
        Players = new List<Player>();

        ListOfDices.Add(new Dice1());
        ListOfDices.Add(new Dice2());
        
        Players.Add(new Player("Player 1"));
        Players.Add(new Player("Player 2"));
    }
    
    public bool IsCurrentPlayerWinner()
    {
        return CurrentPlayer.IsAWinner();
    }

    public void NextPlayer()
    {
        currentPlayerIndex = (currentPlayerIndex + 1) % Players.Count;
    }
    
    public void ExchangeAnimals(Animal animalToGo, Animal animalToGet, int quantityToGo)
    {
        CurrentPlayer.AnimalHerd.ExchangeAnimal(GlobalHerd, animalToGo, animalToGet, quantityToGo);
    }
    
    public List<Animal> RollDices()
    {
        var animals = new List<Animal>();
        var uniqueAnimals = new HashSet<Animal>();
        foreach (var dice in ListOfDices)
        {
            var animal = dice.Roll();
            animals.Add(animal);
            uniqueAnimals.Add(animal);
            
            CurrentPlayer.AnimalHerd.Animals[animal]++;
        }

        foreach (var animal in uniqueAnimals)
        {
            var quantity = CurrentPlayer.AnimalHerd.Animals[animal];
            var pairs = quantity / 2;
            
            var delta = Math.Min(pairs, GlobalHerd.Animals[animal]);
            
            CurrentPlayer.AnimalHerd.Animals[animal] += delta;
            GlobalHerd.Animals[animal] -= delta;
        }

        foreach (var animal in animals)
        {
            CurrentPlayer.AnimalHerd.Animals[animal]--;
        }
        
        return animals;
    }
    
}