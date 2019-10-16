using System.Windows.Forms;

namespace Prog1{
  public class Form1 : Form{

    internal SplitContainer Spc1;

    public Form1(){
      this.Text = "Hello World!";
      Spc1 = new SplitContainer();
      Spc1.Dock = DockStyle.Fill;
      Label lb1 = new Label();
      Label lb2 = new Label();
      lb1.Text = "Hello";
      lb2.Text = "World!";
      Spc1.Panel1.Controls.Add(lb1);
      Spc1.Panel2.Controls.Add(lb2);
      this.Controls.Add(Spc1);
    }
		
    static void Main(){
      Application.Run(new Form1());
    }
  }
}
