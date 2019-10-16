using System.Windows.Forms;

namespace Prog1{
  public class Form1 : Form{
    internal StatusStrip SStrip1;

    public Form1(){
      this.Text = "Hello World!";
      SStrip1 = new StatusStrip();

      ToolStripStatusLabel tsl1 = new ToolStripStatusLabel();
      tsl1.Text = "Hello";
      tsl1.BorderSides = ToolStripStatusLabelBorderSides.Right;
      SStrip1.Items.Add(tsl1);

      ToolStripStatusLabel tsl2 = new ToolStripStatusLabel();
      tsl2.Text = "World!";
      SStrip1.Items.Add(tsl2);
      this.Controls.Add(SStrip1);
    }

    static void Main(){
      Application.Run(new Form1());
    }
  }
}
