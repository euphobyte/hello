using System.Windows.Forms;

namespace Prog1{
  public class Form1 : Form{

    public Form1(){
      this.Text = "Hello World!";
    }

    static void Main(){
      Application.Run(new Form1());
    }
  }
}
