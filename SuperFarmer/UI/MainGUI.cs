// TerminalGuiDesigner MainGUI.cs

using SuperFarmer.Animals;
using SuperFarmer.Core;
using SuperFarmer.UI.Dialogs;
using Terminal.Gui;

namespace SuperFarmer.UI 
{
    
    public partial class MainGUI
    {
        public Label RabbitLabel;
        public Label SheepLabel;
        public Label PigLabel;
        public Label CowLabel;
        public Label HorseLabel;
        public Label DogLabel;
        public Label HoundLabel;
        
        public Game game;
        
        public MainGUI(Game game) {
            this.game = game;
            InitializeComponent();
            this.Title = "Super Farmer";
            // Buttons
            this.buttonQuit.Clicked += () =>
            {
                Application.RequestStop();
                game.gameStopped = true;
            };
            
            // Roll the dice
            List<Animals.Animal> rolledAnimals = new List<Animals.Animal>();
            this.rollTheDicesButton.Clicked += () => {
                rolledAnimals = game.RollDices();
                dice1.Text = $"{rolledAnimals[0]}\n\n{AnimalsASCII.GetAnimalASCII(rolledAnimals[0])}";
                dice2.Text = $"{rolledAnimals[1]}\n\n{AnimalsASCII.GetAnimalASCII(rolledAnimals[1])}";
                this.UpdateAnimalsLabels();
                checkIfGameIsOver();
            };
            
            this.exchangeButton.Clicked += () => {
                var exchangeDialog = new ExchangeDialog(game);
                Application.Run(exchangeDialog);
                this.UpdateAnimalsLabels();
            };
            // Assign ASCII images
            this.animalsBoard.Border = new Border()
            {
                Title = "Animals",
                BorderStyle = BorderStyle.Double
            };
            this.rabbitascii.Text = AnimalsASCII.Rabbit;
            this.sheepascii.Text = AnimalsASCII.Sheep;
            this.pigascii.Text = AnimalsASCII.Pig;
            this.cowascii.Text = AnimalsASCII.Cow;
            this.horseascii.Text = AnimalsASCII.Horse;
            this.dogascii.Text = AnimalsASCII.Dog;
            this.houndascii.Text = AnimalsASCII.Hound;
            
            // Animal labels
            this.exchangeRatesView.Border = new Border()
            {
                BorderStyle = BorderStyle.Double,
                Title = "Exchange Rates",
            };
            exchangeRatesLabel.Text = AnimalsASCII.exchangeRates;
            RabbitLabel = new Label($"Rabbit: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            rabbit.Add(RabbitLabel);
            SheepLabel = new Label($"Sheep: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            sheep.Add(SheepLabel);
            
            PigLabel = new Label($"Pig: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            pig.Add(PigLabel);
            
            CowLabel = new Label($"Cow: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            cow.Add(CowLabel);
            
            HorseLabel = new Label($"Horse: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            horse.Add(HorseLabel);
            
            DogLabel = new Label($"Dog: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            dog.Add(DogLabel);
            
            HoundLabel = new Label($"Hound: 0")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            hound.Add(HoundLabel);


        }

        public void UpdateAnimalsLabels()
        {
            RabbitLabel.Text = $"Rabbit: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Rabbit]}";
            SheepLabel.Text = $"Sheep: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Sheep]}";
            PigLabel.Text = $"Pig: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Pig]}";
            CowLabel.Text = $"Cow: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Cow]}";
            HorseLabel.Text = $"Horse: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Horse]}";
            DogLabel.Text = $"Dog: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Dog]}";
            HoundLabel.Text = $"Hound: {game.CurrentPlayer.AnimalHerd.Animals[Animal.Hound]}";

        }
        
        public void checkIfGameIsOver()
        {
            if (game.IsCurrentPlayerWinner())
            {
                MessageBox.ErrorQuery("Game Over", $"{game.CurrentPlayer.Name} has won the game!", "Ok");
                Application.RequestStop();
            }
        }
   
    }
}
