using SuperFarmer.Animals;
using SuperFarmer.Core;
using Terminal.Gui;

namespace SuperFarmer.UI.Dialogs;

public class ExchangeDialog : Dialog
{
        List<Animal> animalsList = new List<Animal>
        {
            Animal.Rabbit,
            Animal.Sheep,
            Animal.Pig,
            Animal.Cow,
            Animal.Horse,
            Animal.Dog,
            Animal.Hound
        };
    public ExchangeDialog(Game game)
    {
        this.Title = "Exchange animals";
        this.Width = Dim.Percent(50);
        this.Height = Dim.Percent(50);
        this.X = Pos.Percent(25);
        this.Y = Pos.Percent(25);

        var sourceAnimalLabel = new Label()
        {
            X = 0,
            Y = 0,
            Text = "From:"
        };
        var animalsListFromView = new ListView(animalsList)
        {
            X = 0,
            Y = 1,
            Width = Dim.Percent(50),
            Height = Dim.Percent(100),
            AllowsMarking = true,
            AllowsMultipleSelection = false
        };
        
        var targetAnimalLabel = new Label()
        {
            Text = "To:",
            X = Pos.Right(animalsListFromView),
            Y = 0
            
        };
        
        var animalsListToView = new ListView(animalsList)
        {
            X = Pos.Right(animalsListFromView),
            Y = 1,
            Width = Dim.Percent(50),
            Height = Dim.Percent(100),
            AllowsMarking = true,
            AllowsMultipleSelection = false
        };
        
        var quantityLabel = new Label()
        {
            Text = "Quantity:",
            X = 0,
            Y = 10
        };
        
        var quantityText = new TextField("")
        {
            X = Pos.Right(quantityLabel),
            Y = 10,
            Width = Dim.Fill(),
        };
        
        Add(sourceAnimalLabel, animalsListFromView, targetAnimalLabel, animalsListToView, quantityLabel, quantityText);
        
        var exchangeButton = new Button("Exchange");
        exchangeButton.Clicked += () =>
        {
            if (animalsListFromView.SelectedItem == null || animalsListToView.SelectedItem == null || quantityText.Text.ToString() == "")
            {
                MessageBox.ErrorQuery("Error", "Please select animals and quantity", "Ok");
                return;
            }
            var sourceAnimalNum = animalsListFromView.SelectedItem;
            var sourceAnimal = Enum.GetName(typeof(Animal), sourceAnimalNum);
            var targetAnimalNum = animalsListToView.SelectedItem;
            var targetAnimal = Enum.GetName(typeof(Animal), targetAnimalNum);
            var quantity = int.Parse(quantityText.Text.ToString());
            
            game.ExchangeAnimals(AnimalsASCII.stringToAnimal(sourceAnimal!), AnimalsASCII.stringToAnimal(targetAnimal!), quantity);
            MessageBox.ErrorQuery("Success", "Exchange successful", "Ok");
            Application.RequestStop();
        };
        
        var cancelButton = new Button("Cancel");
        cancelButton.Clicked += () =>
        {
            Application.RequestStop();
        };
        
        this.AddButton(exchangeButton);
        this.AddButton(cancelButton);
    }
    
}