// TerminalGuiDesigner MainGUI.cs

using System.Reflection.Metadata;

namespace Terminal.Gui 
{
    
    public partial class MainGUI {
        
        public MainGUI() {
            InitializeComponent();
            this.Title = "Super Farmer (Ctrl + Q to quit)";
            
            // take this.animalBoard and put it's width into new LocalVariable(), then divide it and put 7 boxes in a row

            var animalBoardWidth = this.animalsBoard.Width.GetHashCode();
            var animalBoxHeight = this.animalsBoard.Height;
            int numberOfBoxes = 7;
            
            var animalBox1 = new Terminal.Gui.View();
            animalBox1.Width = animalBoardWidth/numberOfBoxes;
            animalBox1.Height = animalBoxHeight;
            animalBox1.X = 0;
            animalBox1.Y = 0;

            // now nest in animalbox a label with the name of the animal
            var animalBox1Label = new Terminal.Gui.Label();
            animalBox1Label.Width = animalBox1.Width;
            animalBox1Label.Height = 5;
            animalBox1Label.X = 5;
            animalBox1Label.Y = 0;
            animalBox1Label.Visible = true;
            animalBox1Label.Data = "animalBox1Label";
            animalBox1Label.TextAlignment = Terminal.Gui.TextAlignment.Left;
            animalBox1.Add(animalBox1Label);
            
            
            
            this.animalsBoard.Add(animalBox1);
            
            
        }
    }
}
