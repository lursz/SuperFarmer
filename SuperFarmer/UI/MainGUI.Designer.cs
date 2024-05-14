
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v1.1.0.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace SuperFarmer.UI {
    using System;
    using Terminal.Gui;
    
    
    public partial class MainGUI : Terminal.Gui.Window {
        
        private Terminal.Gui.ColorScheme redOnBlack;
        
        private Terminal.Gui.View animalsBoard;
        
        private Terminal.Gui.View rabbit;
        
        private Terminal.Gui.Label rabbitascii;
        
        private Terminal.Gui.View sheep;
        
        private Terminal.Gui.Label sheepascii;
        
        private Terminal.Gui.View pig;
        
        private Terminal.Gui.Label pigascii;
        
        private Terminal.Gui.View cow;
        
        private Terminal.Gui.Label cowascii;
        
        private Terminal.Gui.View horse;
        
        private Terminal.Gui.Label horseascii;
        
        private Terminal.Gui.View dog;
        
        private Terminal.Gui.Label dogascii;
        
        private Terminal.Gui.View hound;
        
        private Terminal.Gui.Label houndascii;
        
        private void InitializeComponent() {
            this.houndascii = new Terminal.Gui.Label();
            this.hound = new Terminal.Gui.View();
            this.dogascii = new Terminal.Gui.Label();
            this.dog = new Terminal.Gui.View();
            this.horseascii = new Terminal.Gui.Label();
            this.horse = new Terminal.Gui.View();
            this.cowascii = new Terminal.Gui.Label();
            this.cow = new Terminal.Gui.View();
            this.pigascii = new Terminal.Gui.Label();
            this.pig = new Terminal.Gui.View();
            this.sheepascii = new Terminal.Gui.Label();
            this.sheep = new Terminal.Gui.View();
            this.rabbitascii = new Terminal.Gui.Label();
            this.rabbit = new Terminal.Gui.View();
            this.animalsBoard = new Terminal.Gui.View();
            this.redOnBlack = new Terminal.Gui.ColorScheme();
            this.redOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Red, Terminal.Gui.Color.Black);
            this.redOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightRed, Terminal.Gui.Color.Black);
            this.redOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Red, Terminal.Gui.Color.Brown);
            this.redOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightRed, Terminal.Gui.Color.Brown);
            this.redOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black);
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Modal = false;
            this.IsMdiContainer = false;
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.Effect3D = false;
            this.Border.Effect3DBrush = null;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "";
            this.animalsBoard.Width = Dim.Fill(0);
            this.animalsBoard.Height = Dim.Percent(40f);
            this.animalsBoard.X = 0;
            this.animalsBoard.Y = 17;
            this.animalsBoard.Visible = true;
            this.animalsBoard.Data = "animalsBoard";
            this.animalsBoard.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.animalsBoard);
            this.rabbit.Width = Dim.Percent(14f);
            this.rabbit.Height = 9;
            this.rabbit.X = 1;
            this.rabbit.Y = 1;
            this.rabbit.Visible = true;
            this.rabbit.Data = "rabbit";
            this.rabbit.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.rabbit);
            this.rabbitascii.Width = 4;
            this.rabbitascii.Height = 1;
            this.rabbitascii.X = Pos.Center();
            this.rabbitascii.Y = 1;
            this.rabbitascii.Visible = true;
            this.rabbitascii.Data = "rabbitascii";
            this.rabbitascii.Text = "rabitascii";
            this.rabbitascii.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.rabbit.Add(this.rabbitascii);
            this.sheep.Width = Dim.Percent(14f);
            this.sheep.Height = 9;
            this.sheep.X = Pos.Right(rabbit);
            this.sheep.Y = 1;
            this.sheep.Visible = true;
            this.sheep.Data = "sheep";
            this.sheep.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.sheep);
            this.sheepascii.Width = 4;
            this.sheepascii.Height = 1;
            this.sheepascii.X = Pos.Center();
            this.sheepascii.Y = 1;
            this.sheepascii.Visible = true;
            this.sheepascii.Data = "sheepascii";
            this.sheepascii.Text = "sheepascii";
            this.sheepascii.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.sheep.Add(this.sheepascii);
            this.pig.Width = Dim.Percent(14f);
            this.pig.Height = 9;
            this.pig.X = Pos.Right(sheep);
            this.pig.Y = 1;
            this.pig.Visible = true;
            this.pig.Data = "pig";
            this.pig.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.pig);
            this.pigascii.Width = 4;
            this.pigascii.Height = 1;
            this.pigascii.X = Pos.Center();
            this.pigascii.Y = 1;
            this.pigascii.Visible = true;
            this.pigascii.Data = "pigascii";
            this.pigascii.Text = "pigascii";
            this.pigascii.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.pig.Add(this.pigascii);
            this.cow.Width = Dim.Percent(14f);
            this.cow.Height = 9;
            this.cow.X = Pos.Right(pig);
            this.cow.Y = 1;
            this.cow.Visible = true;
            this.cow.Data = "cow";
            this.cow.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.cow);
            this.cowascii.Width = 4;
            this.cowascii.Height = 1;
            this.cowascii.X = Pos.Center();
            this.cowascii.Y = 1;
            this.cowascii.Visible = true;
            this.cowascii.Data = "cowascii";
            this.cowascii.Text = "cowascii";
            this.cowascii.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.cow.Add(this.cowascii);
            this.horse.Width = Dim.Percent(14f);
            this.horse.Height = 9;
            this.horse.X = Pos.Right(cow);
            this.horse.Y = 1;
            this.horse.Visible = true;
            this.horse.Data = "horse";
            this.horse.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.horse);
            this.horseascii.Width = 4;
            this.horseascii.Height = 1;
            this.horseascii.X = Pos.Center();
            this.horseascii.Y = 1;
            this.horseascii.Visible = true;
            this.horseascii.Data = "horseascii";
            this.horseascii.Text = "horseascii";
            this.horseascii.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.horse.Add(this.horseascii);
            this.dog.Width = Dim.Percent(14f);
            this.dog.Height = 9;
            this.dog.X = Pos.Right(horse);
            this.dog.Y = 1;
            this.dog.Visible = true;
            this.dog.Data = "dog";
            this.dog.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.dog);
            this.dogascii.Width = 4;
            this.dogascii.Height = 1;
            this.dogascii.X = Pos.Center();
            this.dogascii.Y = 1;
            this.dogascii.Visible = true;
            this.dogascii.Data = "dogascii";
            this.dogascii.Text = "dogascii";
            this.dogascii.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.dog.Add(this.dogascii);
            this.hound.Width = Dim.Percent(14f);
            this.hound.Height = 9;
            this.hound.X = Pos.Right(dog);
            this.hound.Y = 1;
            this.hound.Visible = true;
            this.hound.Data = "hound";
            this.hound.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.animalsBoard.Add(this.hound);
            this.houndascii.Width = 4;
            this.houndascii.Height = 1;
            this.houndascii.X = Pos.Center();
            this.houndascii.Y = 1;
            this.houndascii.Visible = true;
            this.houndascii.Data = "houndascii";
            this.houndascii.Text = "houndascii";
            this.houndascii.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.hound.Add(this.houndascii);
        }
    }
}
