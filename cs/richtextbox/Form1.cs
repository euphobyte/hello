using System.Windows.Forms;
using System.Drawing;

namespace Prog1{
  public class Form1 : Form{

    internal RichTextBox rt1;

    public Form1(){
      this.Text = "Hello World!";
      rt1 = new RichTextBox();
      rt1.Dock = DockStyle.Fill;
      rt1.Text = "Hello\n\tWorld!";

      // Color text red from position 7, 4 characters.
      rt1.SelectionStart = 7;
      rt1.SelectionLength = 4;
      rt1.SelectionColor = Color.Red;
      rt1.DeselectAll();

      // Put Caret at the end of the text.
      rt1.SelectionStart = rt1.TextLength;
      rt1.SelectionLength = 0;
      this.Controls.Add(rt1);
    }

    static void Main(){
      Application.Run(new Form1());
    }
  }
}
