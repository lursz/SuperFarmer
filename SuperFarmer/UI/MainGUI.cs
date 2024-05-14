// TerminalGuiDesigner MainGUI.cs

using SuperFarmer.Animals;
using Terminal.Gui;

namespace SuperFarmer.UI 
{
    
    public partial class MainGUI {
        
        public MainGUI() {
            InitializeComponent();
            this.Title = "Super Farmer (Ctrl + Q to quit)";
            
            // Assign ASCII images
            this.rabbitascii.Text = AnimalsASCII.Rabbit;
            this.sheepascii.Text = AnimalsASCII.Sheep;
            this.pigascii.Text = AnimalsASCII.Pig;
            this.cowascii.Text = AnimalsASCII.Cow;
            this.horseascii.Text = AnimalsASCII.Horse;
            this.dogascii.Text = AnimalsASCII.Dog;
            this.houndascii.Text = AnimalsASCII.Hound;
            



        }
    }
}
