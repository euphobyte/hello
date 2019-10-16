using System.Windows.Forms;
using System.Drawing;

namespace Prog1{
  public class Form1 : Form{

    internal GroupBox GBox1;

    public Form1(){
      this.Text = "Hello World!";
      GBox1 = new GroupBox();
      GBox1.Text = "Group 1";

      TableLayoutPanel TLayout1 = new TableLayoutPanel();
      TLayout1.RowCount = 3;
      TLayout1.ColumnCount = 2;

      TLayout1.Controls.Add(createLabel("Greeting:"),0,0);
      TextBox tb1 = new TextBox();
      tb1.Text = "Hello World!";
      tb1.Anchor = AnchorStyles.Left;
      TLayout1.Controls.Add(tb1,1,0);

      TLayout1.Controls.Add(createLabel("Options:"),0,1);
      ComboBox cmb1 = new ComboBox();
      cmb1.Items.Add("Hello");
      cmb1.Items.Add("World!");
      cmb1.Anchor = AnchorStyles.Left;
      TLayout1.Controls.Add(cmb1,1,1);

      CheckBox cb1 = new CheckBox();
      cb1.Text = "Nice!"; 
      cb1.Anchor = AnchorStyles.Left;
      TLayout1.Controls.Add(cb1,0,2);

      GBox1.Controls.Add(TLayout1);
      TLayout1.Location = new Point(10,20);
      TLayout1.Size = new Size(240,100);
      GBox1.Location = new Point(10,10);
      GBox1.AutoSize =  true;
      this.Controls.Add(GBox1);	
    }

    Label createLabel(string msg){
      Label lb = new Label();
      lb.Text = msg;
      lb.Anchor = AnchorStyles.Left;
      return lb;
    }

    static void Main(){
      Application.Run(new Form1());
    }
  }
}
