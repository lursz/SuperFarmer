using SuperFarmer.Abstracts;
using SuperFarmer.Animals;

namespace SuperFarmer.Core;

public class Game
{
    int currentPlayerIndex = 0;
    
    public List<Player> Players { get; set; }
    public AnimalHerd GlobalHerd { get; set; }
    public Player CurrentPlayer => Players[currentPlayerIndex];
    public List<Dice> ListOfDices { get; set; }
    
    
    public Game()
    {
        GlobalHerd = new AnimalHerd();
        ListOfDices = new List<Dice>();
        Players = new List<Player>();
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
    
    public void ExchangeAnimals(AnimalHerd other, Animal animalToGo, Animal animalToGet, int quantityToGo)
    {
        CurrentPlayer.AnimalHerd.ExchangeAnimal(other, animalToGo, animalToGet, quantityToGo);
    }
    
    public void RollDices()
    {
        foreach (var dice in ListOfDices)
        {
            var animal = dice.Roll();
            CurrentPlayer.AnimalHerd.Animals[animal] += 1;
        }
    }
    
}