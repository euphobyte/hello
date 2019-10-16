using System.Windows.Forms;
using System;

namespace Form1{
  public class Form1 : Form{

    private MainMenu main;

    public Form1(){
      main = new MainMenu();
      MenuItem mh = main.MenuItems.Add("Hello");
      mh.MenuItems.Add("Greeting!", new EventHandler(this.Greeting_Clicked));
      this.Menu = main;
      this.Text = "Hello World!";
    }
		
    private void Greeting_Clicked(object sender, EventArgs e){
      MessageBox.Show("Hello World!");
    }

    static void Main(){
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }
  }
}
