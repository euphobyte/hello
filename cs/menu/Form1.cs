using System.Windows.Forms;

namespace Prog1{
  public class Form1 : Form{

    private MainMenu main;

    public Form1(){
      main = new MainMenu();
      MenuItem mh = main.MenuItems.Add("Hello");
      this.Menu = main;
      this.Text = "Hello World!";
    }

    static void Main(){
      Application.Run(new Form1());
    }
  }
}
