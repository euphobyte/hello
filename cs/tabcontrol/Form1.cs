using System.Windows.Forms;

namespace Prog1{
  public class Form1 : Form{

    internal TabControl TControl1;
 
    public Form1(){
      this.Text = "Hello World!";
      TControl1 = new TabControl();
      TControl1.Controls.Add(createTab("Tab1", "Hello"));
      TControl1.Controls.Add(createTab("Tab2", "World!"));
      TControl1.Dock = DockStyle.Fill;
      this.Controls.Add(TControl1);
    }

    protected TabPage createTab(string tb, string msg){
      TabPage tp = new TabPage();
      tp.Text = tb;
      Label lb = new Label();
      lb.Text = msg;
      tp.Controls.Add(lb);
      return tp;
    }

    static void Main(){
      Application.Run(new Form1());
    }
  }
}
