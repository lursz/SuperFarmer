// TerminalGuiDesigner MainGUI.cs

using SuperFarmer.Animals;
using Terminal.Gui;

namespace SuperFarmer.UI 
{
    
    public partial class MainGUI {
        
        public MainGUI() {
            InitializeComponent();
            this.Title = "Super Farmer (Ctrl + Q to quit)";
            // Buttons
            this.buttonQuit.Clicked += () => Application.RequestStop();
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
            
            // Exchange rates
            this.exchangeRatesView.Border = new Border()
            {
                BorderStyle = BorderStyle.Double,
                Title = "Exchange Rates",
            };
            exchangeRatesLabel.Text = AnimalsASCII.exchangeRates;

            Label rabbitLabel = new Label("Rabbit: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            rabbit.Add(rabbitLabel);
            Label sheepLabel = new Label("Sheep: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            sheep.Add(sheepLabel);
            
            Label pigLabel = new Label("Pig: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            pig.Add(pigLabel);
            
            Label cowLabel = new Label("Cow: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            cow.Add(cowLabel);
            
            Label horseLabel = new Label("Horse: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            horse.Add(horseLabel);
            
            Label dogLabel = new Label("Dog: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            dog.Add(dogLabel);
            
            Label houndLabel = new Label("Hound: ")
            {
                TextAlignment = TextAlignment.Centered,
                X = Pos.Center(),
                Y = 1
            };
            hound.Add(houndLabel);


        }
    }
}
